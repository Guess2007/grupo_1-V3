using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_de_ejercicios__semana_8_
{
    internal class Derecha
    {
        static void Main(string[] args)
        {
            string nom, linea;
            int num;

            Console.WriteLine("Digite lo que desee: "); nom = Console.ReadLine();
            Console.WriteLine("Digite un numero al azar: "); linea = Console.ReadLine().Trim();
            num = int.Parse(linea);
            Console.WriteLine("Derecha (X) letras: " + Right(nom, num));
            Console.WriteLine("Pulse una tecla..."); Console.ReadLine();

        }

        public static string Right(string param, int lenght)
        {
            int value = param.Length - lenght;
            string result = param.Substring(value, lenght);
            return result;
        }
    }
}