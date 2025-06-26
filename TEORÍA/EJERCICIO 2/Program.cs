using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cad = "Lenguaje Programación Java C#";
            //Método split(). Convierte una cadena string a arreglo
            //Debe existir un separador de palabras que se indica como parámetro
            string[] arreglo = cad.Split(' ');

            Console.WriteLine("Palabra 1: " + arreglo[0]);
            Console.WriteLine("Palabra 2: " + arreglo[1]);
            Console.WriteLine("Palabra 3: " + arreglo[2]);
            Console.WriteLine("Palabra 4: " + arreglo[3]);

            Console.WriteLine("Longitud: " + cad.Length);
            Console.WriteLine("Primera Letra: " + cad[0]);
            Console.WriteLine("Ultima letra: " + cad[cad.Length-1]);
            Console.WriteLine("pos Primer espacio: " + cad.IndexOf(' '));
            Console.WriteLine("Primera palabra: " + arreglo[0]);
            Console.WriteLine("Última palabra: " + arreglo[3]);

            //Elabore una función que reciba una cadena y retorne la cantidad de vocales de la cadena.
            //Elabore una función que reciba una cadena y calcule la cantidad de vocales, consonantes,
            //digitos, simbolos especiales de la cadena.

            int con = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i] == 'a')
                    con++;
            }
            Console.WriteLine("Vocales a: " + con);
        }
    }
}
