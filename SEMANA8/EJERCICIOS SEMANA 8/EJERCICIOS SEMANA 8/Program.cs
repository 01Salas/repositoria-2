using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_SEMANA_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Suma: " + ejer4());
            //Console.Write("Ingrese número 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Ingrese número 2: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("\nSuma: " + ejer2(num1,num2));
            Console.ReadKey();
        }

        static void ejer1(int num1, int num2)
        {
           
            Console.Write("Ingrese número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma: " + (num1 + num2));

        }

        static int ejer2(int num1, int num2)
        {
            return num1 + num2;
        }

        static void ejer3()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSuma: " + (num1 + num2));
        }

        static int ejer4()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            return num2 + num1;
        }


    }
}
