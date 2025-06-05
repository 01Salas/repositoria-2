using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EJEMPLOS01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo unidimensional
            int suma;
            int[] n = { 18, 15, 10, 13, 9, 17 };
            Console.WriteLine(n[4]);
            suma = n[0] + n[1] + n[2] + n[3] + n[4] + n[5];

            Console.WriteLine($"La suma es {suma}");

        }
    }
}
