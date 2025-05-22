using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8._5
{
    class Program
    {
        static void Main(string[] args)

        {
            int opcion;
            char continuar;
            do
            {
                do
                {
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. División");
                    Console.WriteLine("0. Salir");

                    Console.Write("\nIngrese una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                } while (opcion < 0 || opcion >= 5);

                Console.Write("Ingrese x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Ingrese y: ");
                int y = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0: Console.WriteLine("Cerrando sistema"); return;
                    case 1:
                        suma(x, y);
                        break;
                    case 2:
                        resta(x, y);
                        break;
                    case 3:
                        multi(x, y);
                        break;
                    case 4:
                        divi(x, y);
                        break;


                }

                Console.WriteLine("\n¿Desea ingresar al menù? (S/N)");
                continuar = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continuar == 's');
        }
            static void suma(int x, int y)
            {
                Console.WriteLine("La suma es: " + (x + y));
            }

            static void resta(int x, int y)
            {
                Console.WriteLine("La resta es: " + (x - y));
            }

            static void multi(int x, int y)
            {
                Console.WriteLine("La suma es: " + (x * y));
            }

            static void divi(int x, int y)
            {
                if (x != 0)
                    Console.WriteLine("La suma es: " + (x / y));
                else Console.WriteLine("No se puede dividir entre 0");
            }
        

    }
}
