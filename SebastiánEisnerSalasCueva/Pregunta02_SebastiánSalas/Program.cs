using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta02_SebastiánSalas
{
    internal class Program
    {
        static int ventasAcademico = 0, ventasNegocios = 0, ventasPlus = 0;
        static int clientesAcademico = 0, clientesNegocios = 0, clientesPlus = 0;
        static double totalAcademico = 0, totalNegocios = 0, totalPlus = 0;
        static void Main(string[] args)
        {

            int tipo, cantidad;
            double importedecompra, importededescuento, importeFinal, totales;

            do
            {

                Console.WriteLine("Tipo de licencias: 1.Académico 2.Negocios 3.Plus 4.Salir");
                tipo = int.Parse(Console.ReadLine());

                if (tipo == 4)
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }

                Console.WriteLine("Cantidad: ");
                cantidad = int.Parse(Console.ReadLine());

                importedecompra = importeCompra(tipo, cantidad);
                Console.WriteLine("El importe de compra es: " + importedecompra);
                importededescuento = importeDescuento(importedecompra, cantidad);
                Console.WriteLine("El descuento del importe es: " + importededescuento);
                importeFinal = importePagar(importedecompra, importededescuento);
                Console.WriteLine("El importe de pagar es: " + importeFinal);
                Totales(tipo, cantidad, importeFinal);
                ImprimirResultado();



            } while (tipo!=4);

            

        }

        static void ImprimirResultado() 
        {
            Console.WriteLine("Cantidad total de licencias Académico: " + ventasAcademico);
            Console.WriteLine("Cantidad total de licencias Negocios: " + ventasNegocios);
            Console.WriteLine("Cantidad total de licencias Plus: " + ventasPlus);

            Console.WriteLine("Clientes con licencias Académico: " + clientesAcademico);
            Console.WriteLine("Clientes con licencias Negocios: " + clientesNegocios);
            Console.WriteLine("Clientes con licencias Plus: " + clientesPlus);

            Console.WriteLine("Total acumulado Académico: S/. " + totalAcademico);
            Console.WriteLine("Total acumulado Negocios: S/. " + totalNegocios);
            Console.WriteLine("Total acumulado Plus: S/. " + totalPlus);

        }

        static double importeCompra(int tipo, int cantidad)
        {
            double precio=0;
            
            switch (tipo) 
            {
                case 1:
                precio = 45;
                    break;
                case 2:
                precio = 75;
                    break;
                case 3:
                precio = 100;
                    break;
                default:
                break;
            
            }
            return precio * cantidad;
        }

        static double importeDescuento(double importe, int cantidad)
        {
            double descuento =0;

            if (cantidad < 4)
                descuento = 0.045;
            else if (cantidad >= 4 && cantidad < 12)
                descuento = 0.07;
            else if (cantidad >= 12)
                descuento = 0.105;

            return importe*descuento;
        }

        static double importePagar(double importeCompra, double importeDescuento) 
        {
            
            return importeCompra - importeDescuento;
        }

        static void Totales(int tipo, int cantidad, double importeFinal)
        {
            switch (tipo)
            {
                case 1:
                    ventasAcademico += cantidad;
                    clientesAcademico++;
                    totalAcademico += importeFinal;
                    break;
                case 2:
                    ventasNegocios += cantidad;
                    clientesNegocios++;
                    totalNegocios += importeFinal;
                    break;
                case 3: 
                    ventasPlus += cantidad;
                    clientesPlus++;
                    totalPlus += importeFinal;
                    break;
            }
              
        }
    }
}
