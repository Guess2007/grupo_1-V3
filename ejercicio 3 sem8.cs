using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        public static string ValidoTexto(string entrada)
        {
            bool valid;
            double num;
            int num1 = 0;
            do
            {
                Console.Write("texto = ");
                entrada = Console.ReadLine(); valid = double.TryParse(entrada, out num);
                if (valid)
                {
                    Console.WriteLine("ingresar un dato de texto valido");

                }
                if (num1 == 1)
                {
                    Console.WriteLine("//quedan 2 oportunidades//");
                }
                if (num1 == 2)
                {
                    Console.WriteLine("//quedan 1 oportunidades//");
                }
                if (num1 == 3)
                {
                    Console.WriteLine("//no quedan oportunidades//");
                    Environment.Exit(0);
                }

                num1++;
            } while (valid);
            return entrada;

        }
        public static string VocalesCerradas(string texto)
        {
            string resultado = "";

            foreach (char c in texto.ToLower())
            {
                if (c == 'i' || c == 'u')
                {
                    resultado += c + " ";
                }
            }

            return resultado;
        }
        static void Main(string[] args)
        {
            string texto = "";
            Console.WriteLine("ingresa la cadena de texto:");
            texto = Program.ValidoTexto(texto);

            texto = VocalesCerradas(texto);

            if (texto == "")
            {
                Console.WriteLine("No se encontraron vocales cerradas (i, u).");
            }
            else
            {
                Console.WriteLine("Las vocales cerradas encontradas son: " + texto);
            }

        }
    }
}
