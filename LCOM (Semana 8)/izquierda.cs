using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_de_ejercicios__semana_8_
{
    internal class Izquierda
    {
        static void Derecha(string[] args)
        {
            string nom, linea;
            int num;

            Console.WriteLine("Digite lo que desee: "); nom = Console.ReadLine();
            Console.WriteLine("Digite un numero al azar: "); linea = Console.ReadLine().Trim();
            num = int.Parse(linea);
            Console.WriteLine("Derecha (X) letras: " + Lefth(nom, num));
            Console.WriteLine("Pulse una tecla..."); Console.ReadLine();

        }

        public static string Lefth(string param, int lenght)
        {
            string result = param.Substring(0, lenght);
            return result;
        }
    }
}
