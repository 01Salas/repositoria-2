using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta01_SebastiánSalas
{
    internal class Program
    {
        static int TotalMedallasOro, TotalMedallasPlata, TotalMedallasBronce, TotalMedallasMencionHonrosa;
        static int canDeportistasOro, canDeportistasPlata, canDeportistasBronce, canDeportistasMencionHonrosa;

        static void Main(string[] args)
        {
            int tipo, cantidad, punAcu;
            string reco;
            do
            {
                Console.WriteLine("Tipo de medalla: 1.Oro 2.Plata 3.Bronce 4.Mención Honrosa 5.Salir: ");
                tipo = int.Parse(Console.ReadLine());

                Console.WriteLine("Cantidad: ");
                cantidad = int.Parse(Console.ReadLine());

                punAcu = puntajeAcumulado_SebastiánSalas(tipo, cantidad);
                reco = reconocimiento_SebastiánSalas(punAcu);
                Incrementos(tipo, cantidad);
                ImprimirResultados(punAcu, reco);
                

            }while (tipo!=5);
        }

        static void ImprimirResultados(int punAcu, string reco)
        {
            Console.WriteLine("Puntaje Acumulado: " + punAcu);
            Console.WriteLine("Reconocimiento: " + reco);
            Console.WriteLine("Total medallas Oro: " + TotalMedallasOro);
            Console.WriteLine("Total medallas Plata: " + TotalMedallasPlata);
            Console.WriteLine("Total medallas Bronce: " + TotalMedallasBronce);
            Console.WriteLine("Total medallas Mención: " + TotalMedallasMencionHonrosa);

            Console.WriteLine("Deportistas Oro: " + canDeportistasOro);
            Console.WriteLine("Deportistas Plata: " + canDeportistasPlata);
            Console.WriteLine("Deportistas Bronce: " + canDeportistasBronce);
            Console.WriteLine("Deportistas  Mención: " + canDeportistasMencionHonrosa);

        }

        static int puntajeAcumulado_SebastiánSalas(int tipo, int cantidad)
        {
            int puntajeAcumulado;
            switch (tipo)
            {
                case 1:
                    puntajeAcumulado = 10 * cantidad;
                    break;
                case 2:
                    puntajeAcumulado = 6 * cantidad;
                    break;
                case 3:
                    puntajeAcumulado = 3 * cantidad;
                    break;
                default:
                    puntajeAcumulado = 1 * cantidad;
                    break;
            }
            return puntajeAcumulado;
        }

        static string reconocimiento_SebastiánSalas(int puntajeAcumulado)
        {
            string reconocimiento;
            if (puntajeAcumulado < 7)
                reconocimiento = "diploma";
            else if (puntajeAcumulado < 14)
                reconocimiento = "Cena Doble";
            else if (puntajeAcumulado < 31)
                reconocimiento = "Pasaje turístico doble";
            else
                reconocimiento = "Paquete turístico integral";

            return reconocimiento;
        } 


        static void Incrementos(int tipo, int cantidad)
        {
            switch (tipo)
            {
                case 1: //Oro
                    TotalMedallasOro += cantidad;
                    canDeportistasOro++;
                    break;
                case 2: //Plata
                    TotalMedallasPlata += cantidad;
                    canDeportistasPlata++;
                    break;
                case 3: //Bronce
                    TotalMedallasBronce += cantidad;
                    canDeportistasBronce++;
                    break;
                default:    //Mención Honrosa
                    TotalMedallasMencionHonrosa +=  cantidad;
                    canDeportistasMencionHonrosa ++;
                    break;
            }
        }
    }
}
