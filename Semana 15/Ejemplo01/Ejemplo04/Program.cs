using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { { 14, 18, 12}, { 11, 17, 13}, { 10, 7, 8} };
            int suma = 0;

            //Obtener la suma de números
            for (int fila = 0; fila < m.GetLength(0); fila++) {
                for (int col = 0; col < m.GetLength(1); col++) {
                    //Calcula la suma de cada fila
                    suma += m[fila, col];
                }
                Console.WriteLine("Suma fila " + fila +": " + suma);
                suma = 0;
            }
            
        }
    }
}
