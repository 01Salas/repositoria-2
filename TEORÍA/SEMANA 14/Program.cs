using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombres = "Carlos Carbajal";
            //Obtenemos la longitud de la cadena
            int longitud = nombres.Length;
            Console.WriteLine($"Longitud: {longitud}");

            int pos = nombres.IndexOf("C");
            Console.WriteLine($"Posicion: {pos}");

            string nombreMayus = nombres.ToUpper();
            Console.WriteLine($"Mayúscula: {nombreMayus}");

            string nombreMinus = nombres.ToLower();
            Console.WriteLine($"Minúsculas: {nombreMinus}");

            string nombre1 = nombres.Substring(7);
            Console.WriteLine($"Nombres: {nombre1}");

            //Extrae una subcadena (6 caracteres) desde la posición 0
             string nombre2 = nombres.Substring(0,6);
             Console.WriteLine($"NOmbres: {nombre2}");

             //string nombres = "Carlos Carbajal"

             int pos1 = nombres.IndexOf("C",1);
             Console.WriteLine($"Posición 2: {pos1}");

            //Extraemos 1 caracter especificando su posición
            Console.WriteLine($"Caracter: {nombres[5]}");

            //De la cadena siguiente, mostrar las primeras letras de cada
            //término
            string estudiante = "Ana Isabel Juarez Lopez"; //Resultado=RMCM
            string letra1, letra2, letra3, letra4;

            letra1 = estudiante[0].ToString();
            letra2 = estudiante[estudiante.IndexOf(" ") + 1].ToString();
            letra3 = estudiante[estudiante.IndexOf(" ", estudiante.IndexOf(" ") + 1) + 1].ToString();
            letra4 = estudiante[estudiante.IndexOf(" ", estudiante.IndexOf(" ", estudiante.IndexOf(" ") + 1) + 1) + 1].ToString();


            Console.WriteLine($"Resultado: {letra1}{letra2}{letra3}{letra4}");
            
        }
    }
}
