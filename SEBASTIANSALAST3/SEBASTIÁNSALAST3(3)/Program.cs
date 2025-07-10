using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBASTIÁNSALAST3_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ventas = new int[6];
            //Llamar o invocar a la función
            LlenarDatos(ventas);
            MostrarDatos(ventas);
            int posTercerPar = PosiciónTercerPar(ventas);
            Console.WriteLine("El 3er par es: " + posTercerPar);
            Console.WriteLine("Antepénultimo múltiplo de 5: " + posiciónAntepénultimoMultiplo5(ventas));
        }
        //Función para llenar el arreglo de aleatorios
        static void LlenarDatos(int[]ventas)
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                ventas[i] = rnd.Next(1, 501);
            }
        }
        //Función para imprimir los datos del arreglo
        static void MostrarDatos(int[]ventas)
        {
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(ventas[i]);
            }
        }
        //Una función que calcule y retorne la posición del
        //tercer número par.
        static int PosiciónTercerPar(int[] ventas)
        {
            int can = 0;

            for (int i = 0; i < 6; i++) 
            {
                if (ventas[i] % 2 == 0) //PAR
                    can++;              //Cuenta la cantidad de pares
                    if (can==3)
                    {
                    return i;
                    }
            }
            return -1; // En caso no hay tercer par
        }

        static int posiciónAntepénultimoMultiplo5(int[] ventas)
        {
            int can = 0;

            for (int i = 0; i>=0; i--)
            {
                if (ventas[i] % 5 == 0) //multiplo de 5
                    can++;              //
                if (can == 3)
                {
                    return i;
                }
            }
            return -1; // En caso no hay tercer par
        }
    }
}
