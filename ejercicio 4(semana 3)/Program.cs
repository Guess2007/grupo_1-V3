using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_semana_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, v, d, s;
            string linea;
            static bool PreguntarSiNo(string pregunta) 
            {
                Console.Write($"{pregunta} (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "s")
                {
                    return true;
                }

                else if (respuesta == "n")
                {
                    return false;
                }   
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese 's' para sí o 'n' para no.");
                    return PreguntarSiNo(pregunta);
                }

            }
        }
    }
}
