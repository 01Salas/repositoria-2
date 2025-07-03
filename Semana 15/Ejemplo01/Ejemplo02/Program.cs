using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { {14,18,12,9,16}, {11, 17, 13, 19, 6}, {10, 7, 8, 15, 12} };

            //Recorrido de un arreglo bidimensional
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    Console.Write(m[fila,col]+"\t");
                }
                Console.WriteLine();// Salto de linea al terminar una fila
            }
            Console.WriteLine();
            Console.WriteLine(m[2,4]);
        }
    }
}
