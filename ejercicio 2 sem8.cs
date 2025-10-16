using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_sem8
{
    internal class Program
    {
        public static string left(string cadena, int num)
        {
            string res = cadena.Substring(0, num);
            return res;
        }
        public static string VoltearTexto(string texto)
        {
            
            char[] caracteres = texto.ToCharArray(); 
            Array.Reverse(caracteres); 
            string TextoVolteado = new string(caracteres);
            return TextoVolteado;
        }
        public static int ValidoInt(int num)
        {
            bool valid;
            string entrada;
            int num1 = 0;
            do
            {
                Console.Write("Numero = ");
                entrada = Console.ReadLine(); valid = int.TryParse(entrada, out num);
                if (!valid)
                {
                    Console.WriteLine("ingresar un dato valido");

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
            } while (!valid);
            return num;

        }
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
        static void Main(string[] args)
        {
            string ent = "";
            int ent1 = 0;
            string resul;

            Console.WriteLine("ingresa la cadena de texto:");
            ent = Program.ValidoTexto(ent);
            ent = Program.VoltearTexto(ent);

            Console.WriteLine("ingresa el numero de cararcteres requeridos : ");
            ent1 = Program.ValidoInt(ent1);

            resul = Program.left(ent, ent1);

            Console.WriteLine("caracteres = " + resul);
        }
       
    }
}
