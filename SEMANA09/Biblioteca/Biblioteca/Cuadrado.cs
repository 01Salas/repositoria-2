using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Cuadrado
    {
        public void area(int l)
        {
            Console.WriteLine("Área: " + l * l);
        }

        public void perimetro(int l)
        {
            Console.WriteLine("Perimetro: " + (l + l + l + l));
        }
    }
}
