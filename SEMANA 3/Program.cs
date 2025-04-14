using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio08();
            Console.ReadKey();
        }

        static void Ejercicio01()
        {
            string nombre;
            Console.Write("Introduzca un nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n" + nombre+ " Bienvenido al curso de Fundamentos de Algoritmos");
        }

        static void Ejercicio02()
        {
            Console.WriteLine("Sebastian\n19\nIng.Sistemas");
        }

        static void Ejercicio03()
        {

            Console.WriteLine("\"Sebastián\"");

        }

        static void Ejercicio04()
        {

            Console.WriteLine();

        }

        static void Ejercicio05()
        {

            int bs, alt;
            double area;
            Console.WriteLine("Ingrese la base del triangulo");
            bs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo: ");
            alt = int.Parse(Console.ReadLine());

            area = (bs * alt) / 2;

            Console.WriteLine("\nEl area del triangulo es: " + area);

        }

        static void Ejercicio06()
        {

            double num1, num2, num3, promedio;

            Console.Write("Ingrese el primer numero: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            num3 = double.Parse(Console.ReadLine());

            promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine("\nEl promedio es: " + Math.Round(promedio, 2));


        }

        static void Ejercicio07()
        {
            int radio;
            double area;

            Console.Write("Ingrese el radio del circulo: ");
            radio = Convert.ToInt32(Console.ReadLine());

            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("\nEl area del circulo es: " + Math.Round(area, 2));
        }

        static void Ejercicio08()
        {
            double num1;

            Console.Write("Ingrese un numero decimal");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nLa raíz cuadrad es: " +Math.Sqrt(num1));
            Console.WriteLine("La potencia a 3 es: " + Math.Pow(num1, 3));
        }

    }
}
