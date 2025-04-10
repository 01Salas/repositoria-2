using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio01();
            Console.ReadKey();
        }

        static void Ejercicio01()
        {
            string nombre;
            Console.Write("Introduzca un nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n" + nombre+ " Bienvenido al curso de Fundamentos de Algoritmos");
        }
    }
}
