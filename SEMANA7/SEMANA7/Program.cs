using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7
{
    class Program
    {
        static void Main(string[] args)
        {

            ejer1();
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
    }
}
