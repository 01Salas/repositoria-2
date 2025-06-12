using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO01
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100 };


            
            //Llamamos a la función
            //int longitud = tamanio(deposito);
            //Console.WriteLine("Tamaño: "+longitud);
            Console.WriteLine("Tamaño: " + tamanio(deposito));

            Console.WriteLine("Deposito obtenido: " + obtenerDeposito(deposito,3));

            Console.WriteLine("Promedio de deposito: " + promedioDepositos(deposito));

            Console.WriteLine("Deposito Mayor: " + depositoMayor(deposito));

            Console.WriteLine("Deposito Menor: " + depositoMenor(deposito));

            Console.WriteLine("Cantidad de depositos mayores a 3000: " + cantidadMayores3000(deposito));

            Console.WriteLine("Cantidad de depositos menores a 2500: " + cantidadMenores2500(deposito));

            Console.WriteLine("Primer valor del rango: " + posPrimerDeposito(deposito));

            Console.WriteLine("Segundo valor del rango: " + posSegundoDeposito(deposito));

            Console.WriteLine("Penultimo valor del rango: " + posPenultimoDeposito(deposito));

            Console.WriteLine("Ultimo valor del rango: " + posUltimoDeposito(deposito));

            //Llamamos a la función reemplazada
            reemplazarDeposito(2, 5555, deposito);
            //Listamos los datos
            ListarDatos(deposito);
            //Generamos los depositos
            GenerarDatos(deposito);
            ListarDatos(deposito);

        }

        //Función que retorna la longitud del arreglo
        //La función recibirá un parámetro de tipo [] arreglo
        static int tamanio(int[] deposito){
            int tamanio = deposito.Length;
            return tamanio;
        }

        //Un método obtenerDeposito que reciba una posición y retorne el depósito almacenado en dicha posición.
        static int obtenerDeposito(int []deposito, int pos)
        {
            return deposito[pos];
        }

        //Un método promedioDepositos que retorne el promedio de todos los depósitos.

        static double promedioDepositos(int[] deposito)
        {
            double promedio=0;
            int suma = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                // Calculamos la suma de depositos
                suma += deposito[i];
            }
            //Calculamos el promedio de esa suma
            promedio = 1.0 * suma / deposito.Length;
            return promedio;
        }

        //Un método depositoMayor que retorne el mayor de los depósitos almacenados.

        static int depositoMayor(int[] deposito)
        {
            int mayor = deposito[0];
            for (int i = 0; i < deposito.Length; i++)
            {
                //Calculamos el mayor deposito
                if (deposito[i] > mayor)
                    mayor = deposito[i];
            }
            return mayor;
        }

        //Un método depositoMenor que retorne el menor de los depósitos almacenados.
        static int depositoMenor(int[] deposito)
        {
            int menor = int.MaxValue;
            for (int i = 0; i < deposito.Length; i++)
            {
                //Calculamos la menor nota
                if (deposito[i] < menor)
                    menor = deposito[i];
            }
            return menor;
        }

        //Un método cantidadMayores3000 que retorne la cantidad de depósitos mayores a 3000.
        static int cantidadMayores3000(int [] deposito)
        {
            int cant = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] > 3000)
                    cant++;
                    
            }
            return cant;
        }
        
        //Un método cantidadMenores2500 que retorne la cantidad de depósitos menores a 2500.
        static int cantidadMenores2500(int[] deposito)
        {

            int cant = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] < 2500)
                    cant++;

            }
            return cant++;
        }

        //Un método posPrimerDeposito que retorne la posición del primer depósito encontrado en el rango de 2000 a 2500. En caso no exista, deberá retornar -1.
        static int posPrimerDeposito(int[] deposito) {
            
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    return deposito[i];
            }
            return -1;// En caso de que no exista un déposito en el rango.
        }

        //Un método posPrimerDeposito que retorne la posición del SEGUNDO depósito encontrado en el rango de 2000 a 2500. En caso no exista, deberá retornar -1.
        static int posSegundoDeposito(int[] deposito)
        {
            int can = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    can++;
                    if (can==2)
                        return deposito[i];
            }
            return -1;// En caso de que no exista un déposito en el rango.
        }

        //Un método posPenultimoDeposito que retorne la posición del último depósito encontrado en el rango de 3500 a 4000. En caso no exista, deberá retornar -1.
        static int posPenultimoDeposito(int[] deposito)
        {
            int can = 0;
            //Recorrido inverso (Desde la última posición)
            for (int i = deposito.Length - 1; i >= 0; i--)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000) 
                    can++;
                if (can == 2)
                    return deposito[i];
            }
            return -1;// En caso de que no exista un déposito en el rango.
        }

        //Un método posUltimoDeposito que retorne la posición del último depósito encontrado en el rango de 3500 a 4000. En caso no exista, deberá retornar -1.
        static int posUltimoDeposito(int[] deposito)
        {
            //Recorrido inverso (Desde la última posición)
            for (int i = deposito.Length-1; i>=0; i--)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000)
                    return deposito[i];
            }
            return -1;// En caso de que no exista un déposito en el rango.
        }

        //Un método reemplazarDepósito que reciba como parámetros la posición y el nuevo depósito y ejecute el reemplazo en el arreglo.
        static void reemplazarDeposito(int pos, int nuevoDep, int[]deposito)
        {
            deposito[pos] = nuevoDep;
        }

        static void ListarDatos(int[] deposito)
        {
            for (int i = 0; i < deposito.Length; i++)
            {
                Console.WriteLine(deposito[i]);
            }
        }

        //Un método generarDepositos que remplace los depósitos actuales por otros valores aleatorios comprendidos en el rango de 2000 a 10000.
        static void GenerarDatos(int[] deposito)
        {
            Random rnd = new Random();
            for (int i = 0; i < deposito.Length; i++)
            {
                deposito[i] = rnd.Next(2000, 10000);
            }
        }
    }
}
