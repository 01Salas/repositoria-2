using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CasoComputadora
{
    class Program
    {
        static string marca;
        static void Main(string[] args)
        {
            string marca;
            
            int cantidad;
            double iC, iD, iP, obs;
            Console.Write("Ingrese marca: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            //Llamamos a las funciones
            iC = importeCompra(marca, cantidad);
            iD = importeDescuento(cantidad, iC);
            iP = importePago(iC, iD);
            obs = obsequio(marca);

            Console.WriteLine("Importe compra: " + iC);
            Console.WriteLine("Importe descuento: " + iD);
            Console.WriteLine("Importe pago: " + iP);
            Console.WriteLine("Obsequio: " + obs);
        }
        
        static int obsequio(string marca)
        {
            int obs;
            if (marca=="HP")
                obs = 3;
            else
                obs = 0;
            return obs;
        }
        //Función que calcula y retorna el importe de compra

        //Si una variable se ingresa por el teclado, entonces, se declara como parámetro.
        static double importeCompra(string marca, int cantidad)
        {
            double precio =0;
            switch (marca)
            {
                case "Dell":
                    precio = 11000;
                    break;
                case "HP":
                    precio =  9000;
                    break;
                case "Apple":
                    precio = 13000;
                    break;
                case "Asus":
                    precio = 12500;
                    break;
               
            }
            return cantidad*precio;

        }
        //Función que calcula y retorna el importe de compra.
        //Si una variable se ingresa por el teclado, entonces, se declara como parámetro.
        //Si una variable se calculó en una función anterior, entonces, se declara como parámetro.
        static double importeDescuento(int cantidad, double iCom)
        {
            double iDes;
            if (cantidad <= 3)
                iDes = 3.5 / 100 * iCom;
            else if (cantidad < 6)
                iDes = 5.0 / 100 * iCom;
            else if (cantidad <9)
                iDes = 6.5 / 100 * iCom;
            else
                iDes = 8.0 / 100 * iCom;

            return iDes;

        }

        static double importePago(double impCom, double iDes)
        {

            return impCom - iDes;

        }
    }
}
