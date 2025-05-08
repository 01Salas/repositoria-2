using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA6
{
    class Program
    {
        static void Main(string[] args)
        {
            ejer7();
            Console.ReadKey();
        }

        static void ejer1()
        {

            int i = 1;

            while(i <= 100)
            {
                Console.Write(i + " ");
                i++;

            }

        }

        static void ejer2()
        {

            Console.Write("Ingese un número entero:");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.Write("Debe ser positivo. Intente nuevamente:  ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            while(n >= 0)
            {

                Console.Write(n + " ");
                n--;
            }
        }

        static void ejer3()
        {

            Console.Write("Ingrese un numeros (0 para salir): \n");

            int numero = 1;

            while(numero !=0)
            {

                Console.Write("Numero: ");
                numero = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\nProgama Finalizado!");

        }

        static void ejer4()
        {
            int n;

            Console.Write("Ingrese un número mayor a 0: ");
            n = int.Parse(Console.ReadLine());

            while (n<=0)
            {
                Console.Write("Número inválido. Ingrese nuevamente: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int i = 1;

            while (i <= 12)
            {
                Console.WriteLine($" {n} * {i} = {i * n}");
                i++;
            }
        }

        static void ejer5()
        {

            int num;
            int sumP = 0, sumI = 0;

            while (true)
            {

                Console.Write("Ingrese número: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                if (num < 0)
                {
                    Console.Write("Número inválido. Solo se permiten enteros mayores a 0: ");
                    continue;
                }
                if (num % 2 == 0) sumP += num;
                else sumI += num;

            }
            Console.WriteLine();
            Console.WriteLine("Suma de pares: " + sumP);
            Console.WriteLine("Suma de impares: " + sumI);
        }

        static void ejer6()
        {
            Console.Write("Ingrese # filas: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Ingrese # columnas: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int i = 0;
            while (i<f)
            {
                int j = 0;
                while (j < c)
                {
                    Console.Write("*" + " ");
                        j++;
                }
                Console.WriteLine();
                i++;
            }

        }

        static void ejer7()
        {
            int intentos = 3;
            string ingreso; 
            Console.Write("Ingrese una contraseña: ");
            string contra = Console.ReadLine();

            Console.WriteLine("******************\n");

            Console.WriteLine("Ingresa la contraseña: ");
            ingreso = Console.ReadLine();

            while (intentos >= 0)
            {

                if (ingreso == contra)
                {
                    Console.WriteLine("\nAcceso correcto!");
                    return;
                } else
                {
                    intentos--;
                    if (intentos > 0) Console.WriteLine("\nContraseña incorrecta");
                    else Console.WriteLine("\n Acceso Bloqueado. Ha superado en número de intentos!");
                }

            }
        }
    }
}
