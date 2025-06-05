using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Semana_11_TALLER
{
    class Program
    {
        static void Main(string[] args)
        {
            ejer8();
            Console.ReadKey();
        }

        static void ejer1()
        {
            int[] num = new int[5];
           
            for (int i=0; i<num.Length; i++)
            {
                Console.Write($"Ingrese el número {i+1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros ingresados: ");
            foreach(int n in num)
            {
                Console.WriteLine(n);
            }
        }

        static void ejer2()
        {

            int[] num = { -2, 5, -1, 0, 8, -6, 3 };

            Console.WriteLine("Arreglo original: ");
            foreach (int n in num)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\nArreglo modificado: ");
            for(int i = 0; i<num.Length; i++)
            {
                if (num[i] < 0)
                    num[i] = 0;
            }
            foreach (int n in num)
                Console.Write(n + " ");
        }

        static void ejer3()
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };
            Console.Write("num = [ ");
            foreach (int n in num)
                Console.Write(n + ", ");
            Console.Write("]");

            int maximo = num[0];
            int minimo = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minimo)
                    minimo = num[i];
                if (num[i] > maximo)
                    maximo = num[i];
            }

            Console.WriteLine("\nMínimo: " + minimo);
            Console.WriteLine("Máximo: " + maximo);
        }

        static void ejer4()
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Números pares ingresados:");
            foreach(int n in num)
            {
                if (n % 2 == 0)
                    Console.WriteLine(n);
            }
        }


        static void ejer5()
        {
            Console.Write("¿Cuántos números desea ingresar?: ");
            int cant = int.Parse(Console.ReadLine());
      
            int[] num = new int[cant];
            int suma = 0;
            for(int i=0; i<cant; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];
            }
            Console.WriteLine("\nNúmeros ingresados: ");
            foreach (int n in num)
                Console.Write(n + " ");

            Console.WriteLine("\nSuma: " + suma);
        }

        static void ejer8()
        {
            string[] nom = { "jose", "oscar", "carmen", "alexa" };
            foreach (string n in nom)
                Console.WriteLine(n);

            Console.Write("\nIngrese nombre a modificar: ");
            string ingreso = Console.ReadLine();

            bool modificado = false;

            for (int i = 0; i < nom.Length; i++)
            {
                if( nom[i] == ingreso)
                {
                    Console.Write("Ingrese el nuevo nombre: ");
                    nom[i] = Console.ReadLine();
                    modificado = true;
                    break;
                }
            }

            if (modificado == false)
                Console.WriteLine("Nombre no encontrado!");

            Console.WriteLine("\nNombres actualizados: ");
            foreach (string n in nom)
                Console.WriteLine(n);
        }
    }
}
