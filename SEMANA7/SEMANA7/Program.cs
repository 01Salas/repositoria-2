using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7
{
    class Program
    {
        static void Main(string[] args)
        {

            ejer5();
            Console.ReadKey();

        }

        static void ejer1()
        {
            int num;
            do
            {
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
            } while (num >= 0);
        }

        static void ejer2()
        {

            int num, suma=0;

            do
            {
                Console.Write("Ingrese un número");
                num = int.Parse(Console.ReadLine());

                if (num > 0) suma += num;
            } while (num != 0);
            Console.WriteLine("\nSuma de positivos: " + suma);

        }

        static void ejer3()
        {
            int num, pares = 0, impares = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0 && num >= 0) pares++;
                else if (num >=0)impares++;

            } while (num >= 0);
            Console.WriteLine("\nCant.Pares: " + pares);
            Console.WriteLine("\nCant.Impares: " + impares);
        }

        static void ejer4()
        {
            int num, canMen15 = 0, canMay50 = 0, enRango = 0;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if (num < 15 & num != 0) canMen15++;
                else if (num > 50) canMay50++;
                else if (num >= 25 && num <= 45) enRango++;
            } while (num != 0);

            Console.WriteLine("\nCant. menores que 15: " + canMen15);
            Console.WriteLine("Cant. mayores que 50: " + canMay50);
            Console.WriteLine("En. Rango 25-45: " + enRango);

        }

        static void ejer5()
        {

        }
        static void ejer6()
        {
            char opcion;

            do
            {
                Console.Write("Ingrese un número entero positivo: ");
                int num = int.Parse(Console.ReadLine());

                if (num <= 0) Console.Write("El número debe de ser mayor a 0");
                else
                {
                    int suma = 0;
                    int i = 1;

                    do
                    {
                        suma += i;
                        i++;
                    } while (i <= num);
                    Console.WriteLine("\nSuma: " + suma);
                }
                Console.WriteLine("\n¿Desea calcular la suma de otro número? (S/N): ");
                opcion = char.ToUpper(Console.ReadKey().KeyChar);
                Console.Clear();
            } while (opcion == 'S');

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
