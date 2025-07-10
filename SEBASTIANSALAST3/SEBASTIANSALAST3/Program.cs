using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBASTIANSALAST3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, den;
            double suma=0; //En contadores o acumuladores iniciar en 0
            num = 45;
            den = 3;

            for (int i = 1; i <= 15; i++) { 
            Console.WriteLine(num + "/" + den + "="+ (1.0*num/den).ToString("F2")); // 45/3  43/6  41/12
                suma += 1.0 * num / den;// 45/3 + 43/6 + 41/12
                num -= 2;// num disminuye de 2 en 2
                den *= 2;// den multiplica en 2
            }
            Console.WriteLine("Suma: "+suma);
        }
    }
}
