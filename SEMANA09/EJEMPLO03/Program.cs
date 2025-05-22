using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO03
{
    class Program
    {
        static int n1, n2, suma, resta, multi;
        static double division;
        static void Main(string[] args)
        {
            Console.Write("Número 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            n2 = int.Parse(Console.ReadLine());

            //Llamamos a la función con parámetros
            suma = sumaNumeros(n1,n2);
            resta = restaNumeros(n1,n2);
            multi = multiplicacionNumeros(n1,n2);
            division = dividirNumeros(n1,n2);

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicación es: " + multi);
            Console.WriteLine("La division es: " + division);
        }
        //Creamos una función CON parámetros
         //(Recibe valores) que calcule y retorne 
         //la suma de 2 números

        static int sumaNumeros(int a, int b)
        {
            suma = a + b;
            return suma;
        }

        static int restaNumeros(int a, int b)
        {
            resta = a - b;
            return resta;
        }

        static int multiplicacionNumeros(int a, int b)
        {
            multi = a * b;
            return multi;
        }

        static double dividirNumeros(int a, int b)
        {
            division = a/b * 1.0;
            return division;
        }

    }
}
