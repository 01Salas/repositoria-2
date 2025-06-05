using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EJEMPLO02
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] n = { 18, 15, 10, 13, 9, 17 };
           //Recorrido del arreglo
           for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

            //Calculamos la cantidad de aprobados y desaprobados

            int canAprobados = 0, canDesprobados = 0, suma=0;
            int mayor = n[0], menor = n[0];
            double promedio;
           for (int i = 0; i < n.Length; i++)
            {
                //Calculamos la suma de notas
                suma += n[i];
                //Determinamos la cantidad de aprobados o desaprobados
                if (n[i]>=12)
                        canAprobados++;
                else 
                        canDesprobados++;
            }
            //Llamamos a la función que calcula el mayor
            mayor = mayorNumero(n);
            //Llamamos a ala función que calcula el menor
            menor = menorNumero(n);
            //Llamamos a la función que calcula el promedio
            promedio = promedioNumeros(n);

            Console.WriteLine($"Aprobados: {canAprobados}");
            Console.WriteLine($"Desaprobados: {canDesprobados}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Mayor: {mayor}");
            Console.WriteLine($"Menor: {menor}");
        }
        //Función que retorna el promedio
        static double promedioNumeros(int [ ]n)
        {
            double promedio;
            int suma = 0;
            for (int i = 0; i < n.Length; i++)
            {
                //Calculamos la suma de notas 
                suma += n[i];
            }
            //Calculamos
            promedio = 1.0 * suma / n.Length;
            return promedio;
        }

        static int mayorNumero(int[] n)
        {
            int mayor=0;
            for (int i = 0; i < n.Length; i++)
            {
                //Calculamos la mayor nota
                if (n[i] > mayor)
                    mayor = n[i];
            }
            return mayor;
        }

        static int menorNumero(int[] n)
        {
            int menor = int.MaxValue;
            for (int i = 0; i < n.Length; i++)
            {
                //Calculamos la menor nota
                if (n[i] < menor)
                    menor = n[i];
            }
            return menor;
        }
    }
}
