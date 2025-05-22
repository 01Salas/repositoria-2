using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO02
{
    class Program
    {
        static int n1, n2, suma, resta, multiplicacion;
        static double division;
        static void Main(string[] args)
        {

            
            Console.Write("Número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            n2 = int.Parse(Console.ReadLine());

            //Llamamos a la función creada
            suma = sumaNumeros();
            resta = restaNumeros();
            multiplicacion = multiplicaNumeros();
            division = divideNumeros();
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("la resta es: " + resta);
            Console.WriteLine("la multiplicación es: " + multiplicacion);
            Console.WriteLine("la división es: " + division);


        }
        //Creamos una función sin parámetros que 
        //calcule y retorne la suma de 2 números

        static int sumaNumeros()
        {
            suma = n1 + n2;
            return suma;
        }

        static int restaNumeros()
        {
            resta = n1 - n2;
            return resta;
        }

        static int multiplicaNumeros()
        {
            multiplicacion = n1 * n2;
            return multiplicacion;
        }

        static double divideNumeros()
        {
            division = n1 / n2*1.0;
            return division;
        }
    }
}
