using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { { 14, 18, 12, 9, 16 }, { 11, 17, 13, 19, 6 }, { 10, 7, 8, 15, 12 } };
            int suma = 0, mayor = m[0,0], menor = m[0, 0], sumaDiagPrin= 0;
            //Obtener la suma de números
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    //Calcula la suma de números
                    suma += m[fila, col];
                    //Calcula el mayor
                    if (m[fila, col] > mayor)
                        mayor = m[fila, col];
                    //Calcula el menor
                    if (m[fila, col] < menor)
                        menor = m[fila, col];
                    //Calcula la suma de la diagonal principal
                    if (fila == col)
                        sumaDiagPrin += m[fila, col];
                    //Calcula la suma de cada fila
                    if ()
                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + 1.0*suma/(m.GetLength(0) * m.GetLength(1)));
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Suma de la diagonal principal: " + sumaDiagPrin);
        }
    }
}
