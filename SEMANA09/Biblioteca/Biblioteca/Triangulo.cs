using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Biblioteca
{
    public class Triangulo
    {
        public void area()
        {
            Console.WriteLine("Ingrese la altura: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la base: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÁrea: " + (b * h) / 2);
        }

        public void perimetro()
        {
            Console.WriteLine("Ingrese lado 1: ");
            int l1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 3: ");
            int l3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerimetro: " + (l1 + l2 + l3));
        }
    }
}
