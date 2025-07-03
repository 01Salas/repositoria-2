using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO04
{
    public class Producto
    {
        public string nombre;
        public double precio;
        public int stock;

        public Producto(string nombre, double precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public string Mostrar()
        {
            return "Nombre: " + nombre + ", Precio: S/ " + precio.ToString("0.00") + ", Stock: " + stock;
        }
    }

    public class RegistroProductos
    {
        private List<Producto> productos;

        public RegistroProductos()
        {
            productos = new List<Producto>();
        }

        public void RegistrarProducto()
        {
            Console.WriteLine("\n**** Registre el nuevo producto ****");
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            double precio = -1;
            Console.Write("Ingrese el precio del producto: ");
            string entradaPrecio = Console.ReadLine();
            precio = double.Parse(entradaPrecio);

            while (precio < 0)
            {
                Console.Write("Precio inválido. Ingrese un precio positivo: ");
                entradaPrecio = Console.ReadLine();
                precio = double.Parse(entradaPrecio);
            }

            int stock = -1;
            Console.Write("Ingrese el stock del producto: ");
            string entradaStock = Console.ReadLine();
            stock = int.Parse(entradaStock);

            while (stock < 0)
            {
                Console.Write("Stock inválido. Ingrese un número entero positivo: ");
                entradaStock = Console.ReadLine();
                stock = int.Parse(entradaStock);
            }

            Producto nuevo = new Producto(nombre, precio, stock);
            productos.Add(nuevo);
            Console.WriteLine("Producto registrado exitosamente!");
        }

        public void MostrarProductos()
        {
            Console.WriteLine("\n****Productos Registrados****");
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                for (int i = 0; i < productos.Count; i++)
                {
                    Console.WriteLine(i + ". " + productos[i].Mostrar());
                }
            }
        }

        public void ModificarProducto()
        {
            Console.WriteLine("\n****Modificar Producto****");
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para modificar.");
                return;
            }

            MostrarProductos();
            Console.Write("Ingrese el número del producto a modificar: ");
            int indice = -1;
            try
            {
                indice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            if (indice >= 0 && indice < productos.Count)
            {
                Console.Write("Nuevo nombre: ");
                string nuevoNombre = Console.ReadLine();

                double nuevoPrecio = -1;
                while (nuevoPrecio < 0)
                {
                    Console.Write("Nuevo precio: ");
                        nuevoPrecio = double.Parse(Console.ReadLine());
                    if (nuevoPrecio < 0)
                    {
                        Console.WriteLine("No puede ser negativo.");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un número válido.");
                    }
                }

                int nuevoStock = -1;
                while (nuevoStock < 0)
                {
                    Console.Write("Nuevo stock: ");
 
                        nuevoStock = int.Parse(Console.ReadLine());
                        if (nuevoStock < 0) { 
                            Console.WriteLine("No puede ser negativo.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un número válido.");
                        }
                }

                productos[indice].nombre = nuevoNombre;
                productos[indice].precio = nuevoPrecio;
                productos[indice].stock = nuevoStock;

                Console.WriteLine("Producto modificado correctamente!");
            }
            else
            {
                Console.WriteLine("Número fuera de rango.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegistroProductos registro = new RegistroProductos();
            int opcion = -1;

            while (opcion != 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n***MENÚ***");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                Console.ResetColor();

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        registro.RegistrarProducto();
                        break;
                    case 2:
                        registro.MostrarProductos();
                        break;
                    case 3:
                        registro.ModificarProducto();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar el sistema.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }

            Console.WriteLine("Presione una tecla para cerrar...");
            Console.ReadKey();
        }
    }


}
