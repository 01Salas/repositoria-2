using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese sus apellidos: ");
            string ape = Console.ReadLine().Trim();
            Console.Write("Ingrese sus nombres: ");
            string nom = Console.ReadLine().Trim();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("\nApellidos: "+ape);
            Console.WriteLine("Nombres: "+nom);

            Console.WriteLine("Cantidad de caracteres en apellidos: " + ape.Length);

            Console.WriteLine("Nombres mayusculas: "+nom.ToUpper());
            Console.WriteLine("Apellidos minusccula: "+ape.ToLower());

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if (ape.CompareTo(nom) == 0)
                Console.WriteLine("Apellidos y nombres son iguales");
            else
                Console.WriteLine("Apellidos y nombres no son iguales");

            if (nom.Contains("an"))
                Console.WriteLine("El nombre contiene la palabra \"an\"");
            else
                Console.WriteLine("El nombre contiene la palabra \"an\"");

            if (ape.Contains("a"))
            {
                Console.WriteLine("Primera posición de \"a\": "+ape.IndexOf("a"));
                Console.WriteLine("Ultima posición  de \"a\": "+ape.LastIndexOf("a"));
            } else
            {
                Console.WriteLine("En apellidos no contiene la letra \"a\"");
            }

            Console.WriteLine("Nombres instertando UPN: " + nom.Insert(0, "UPN "));

            Console.WriteLine("Insertando sistemas al final: " + ape.Insert(ape.Length, " SISTEMAS"));

            if(ape.Length > 5)
            {
                Console.WriteLine("Apellidos eliminado caracteres desde la 5ta posición: " + ape.Remove(5));
            }
            else
            {
                Console.WriteLine("Apellidos no tiene mas de 5 caracteres");
            }

            if (nom.Contains("a"))
            {
               Console.WriteLine("En nombres remplazando la a por @: " +nom.Replace("a", "@"));
            }
            else
                Console.WriteLine("En nombres no contiene la letra \"a\"");

            if (ape.Contains("a"))
            {
                string[] split = ape.Split('a');

                foreach(string s in split)
                {
                    Console.WriteLine(s);
                }
            }
            else
                Console.WriteLine("En apellidos no contiene la letra \"a\"");

            if (nom.Length > 4)
            {
                Console.WriteLine(nom.Substring(4));
            }
            else
                Console.WriteLine("Apellidos no contiene mas de 4 caracteres");


            char[] nombres = nom.ToCharArray();

            for (int i = 0; i<nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            Array.Reverse(nombres);
            Console.Write("Nombre en reversa: " + nombres);

            Array.Sort(nombres);
            Console.Write("Nombre ordenados: " + nombres);

                Console.ReadKey();
        }
    }
}
