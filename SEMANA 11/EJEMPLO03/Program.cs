using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];

            
            llenarDatos(n);
            listarDatos(n);
            int aprobado1 = primerAprobado(n), aprobado2 = segundoAprobado(n);
            if (aprobado1 == -1)
                Console.WriteLine("No existen notas aprobatorias!");
            else
                Console.WriteLine($"Primera nota aprobada: {aprobado1}");
            
            if (aprobado2 == -1)
                Console.WriteLine("No existen notas aprobatorias!");
            else
                Console.WriteLine($"Segunda nota aprobada: {aprobado2}");
        }
        static int segundoAprobado(int[] n)
        {
            int canAprobados = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 12)
                {
                    canAprobados++;
                    if (canAprobados == 2)
                        return n[i];
                }
            }
            return -1; //Retorna -1 cuanod no hay aprobados
        }

        //´Función que retorna la primera nota aprobatoria
        static int primerAprobado(int[] n)
        {
            for (int i = 0; i<n.Length; i++)
            {
                if (n[i] >= 12)
                    return n[i];
            }
            return -1; //Retorna -1 cuanod no hay aprobados
        }

        //Función que llena el arreglo con números a aleatorios de 0 a 20
        static void llenarDatos(int[]n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(0, 21);   
            }
        }
        //Función que recibe arreglo y lo imprime

        static void listarDatos(int[]n)
        {
            for (int i=0; i <n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
