using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { { 14, 18, 12 }, { 11, 17, 13 }, { 10, 7, 8 } };
            int suma = 0;

            
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    //Calcular la suma de los elementos del entorno de la matriz
                    if(fila ==0 || col == 0 || fila==m.GetLength(0)-1 || col==m.GetLength(1)-1)
                    {
                        if (m[fila, col]%2==0)
                        suma += m[fila, col];
                    }
                }
               
            }
            Console.WriteLine("Suma: " + suma);
        }
    }
}
