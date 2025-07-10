using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEBASTIÁNSALAST3_2_
{
    internal class Program
    {
        //
        static int num=45, den=3;
        static double suma=0;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine(num + "/" + den + "=" + (1.0 * num / den).ToString("F2")); // 45/3  43/6  41/12
                num -= 2;// num disminuye de 2 en 2
                den *= 2;// den multiplica en 2
            }
            //Calculamos la suma
            suma = sumaFracciones();
            Console.WriteLine("Suma: " + suma.ToString("F3"));
        }

        //Función que calcula la suma de las fracciones
        static double sumaFracciones()
        {
            int num = 45, den = 3;
            for (int i = 1; i < 15; i++)
            {
                suma += 1.0 * num / den;
                num -= 2;
                den *= 2;
            }
            return suma;
        }
    }
}
