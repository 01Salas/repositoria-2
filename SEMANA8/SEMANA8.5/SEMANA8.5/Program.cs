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
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("0. Salir");

                Console.Write("\nIngrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (opcion < 0 || opcion >= 5);
        }

        static void suma (int x, int y)
        {

        }
    }
}
