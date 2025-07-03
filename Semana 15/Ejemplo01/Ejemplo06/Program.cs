using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo06
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] n = new int[5, 3];
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
                for (int col = 0; col < n.GetLength(1); col++)
                {
                    n[fila, col] = rnd.Next(0,21);
                }

            }

            //Mostramos los valores en consola
            //for (int fila = 0; fila < n.GetLength(0); fila++)
            //{
                //for (int col = 0; col < n.GetLength(1); col++)
                //{
                    //Console.Write(n[fila, col] + "\t");
                //}
                //Console.WriteLine();
            //}

           imprimeDatos(n);
        }

        static void imprimeDatos(int[,] n)
        {
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
                for (int col = 0; col < n.GetLength(1); col++)
                {
                    Console.Write(n[fila, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
