using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CASO01
{
    class Program
    {

        static byte[] edades = new byte[0];
        static int cantidad;
        static void Main(string[] args)
        {
            int opcion;
            string continuar;

            do
            {


                Console.WriteLine("1. insertar");
                Console.WriteLine("2. mostrar");
                Console.WriteLine("3. eliminar");
                Console.WriteLine("4. ordenar");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: insertar(); break;
                    case 2: mostrar(); break;
                    case 3: eliminar();  break;
                    case 4: ordenar(); break;
                    case 5:; return;
                    
                }
                Console.WriteLine("Para consituar escriba (si): ");
                continuar = Console.ReadLine();
                Console.Clear();

            } while (continuar == "si");
        }

        static void insertar()
        {
            string cont;
            do
            {

                Console.Write("Ingrese la edad: ");
                byte ed = byte.Parse(Console.ReadLine());

                Array.Resize(ref edades, edades.Length + 1);

                edades[cantidad] = ed;
                cantidad++;

                Console.WriteLine("\nRegistro correcto! \n\nDesea seguir registrando(si)?: ");
                cont = Console.ReadLine();
            } while (cont == "si");
        }

        static void mostrar()
        {
            Console.WriteLine("\nEdades registradas: ");
            for(int i=0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }
        
        }

        static void eliminar()
        {
            Console.Write("Ingrese el número a eliminar: ");
            byte eli = byte.Parse(Console.ReadLine());
            int  indice =-1;
            for(int i=0; i < edades.Length; i++)
            {
                if (edades[i] == eli)
                {
                    indice = i;
                }
            }

            if (indice != -1)
            {
                for (int i = indice; i < edades.Length-1; i++)
                {
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref edades, edades.Length - 1);
                cantidad--;
                Console.WriteLine("\nEdad eliminada con exito!");
            } else
            {
                Console.WriteLine("\nEl número no existe no se puede eliminar!");
            }
        }

        static void ordenar()
        {
            for (int i = 0; i < edades.Length; i++)
            {
                for (int j=0; j< edades.Length - i - 1; j++)
                {
                    if (edades[j] < edades[j + 1])
                    {
                        byte temp = edades[i];
                        edades[j] = edades[j + 1];
                        edades[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSe ordeno correctamente!");
        }
    }
}
