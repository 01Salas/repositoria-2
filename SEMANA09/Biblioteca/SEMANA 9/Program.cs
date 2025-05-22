using System;
using System.Collections.Generic;
using System.Text;

using Biblioteca;

namespace SEMANA_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Cuadrado c = new Cuadrado();
            Rectangulo r = new Rectangulo();
            Trapecio tr = new Trapecio();

            int opcion, opcion2;
            do
            {
                Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULOS DE ÁREAS Y PERIMETRO\n");
                Console.WriteLine("***** Menú de opciones *****");
                Console.WriteLine("*        1. Triangulo      *");
                Console.WriteLine("*        2. Cuadrado       *");
                Console.WriteLine("*        3. Rectángulo     *");
                Console.WriteLine("*        4. Trapecio       *");
                Console.WriteLine("*        0. Salir          *");
                Console.WriteLine("****************************");

                Console.WriteLine("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 0 | opcion > 4);
            
            switch (opcion)
            {
                case 0: return;
                case 1:
                    Console.WriteLine("*****    Triangulo  *****");
                    Console.WriteLine("*        1. Área        *");
                    Console.WriteLine("*        2. Perimetro   *");
                    Console.WriteLine("*************************\n");

                    Console.WriteLine("Ingrese opcion: ");
                    opcion2 = int.Parse(Console.ReadLine());

                    switch (opcion2)
                    {
                        case 1: t.area();
                            break;
                        case 2: t.perimetro(); 
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("*****    Cuadrado   *****");
                    Console.WriteLine("*        1. Área        *");
                    Console.WriteLine("*        2. Perimetro   *");
                    Console.WriteLine("*************************\n");

                    Console.WriteLine("Ingrese opcion: ");
                    opcion2 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el lado: ");
                        int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcion2)
                    {
                        case 1:
                            c.area(lado);
                            break;
                        case 2:
                            c.perimetro(lado);
                            break;
                    }

                    break;
                case 3: break;
                case 4: break;
            }

        }
    }
}
