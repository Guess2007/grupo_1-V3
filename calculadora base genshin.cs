using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public static double ValidoDouble(string entrada)
        {
            bool valid;
            double num;
            int num1 = 0;
            do
            {
                Console.Write("Numero = ");
                entrada = Console.ReadLine(); valid = double.TryParse(entrada, out num);
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
        public static double CriticDMG(double num1, double num2)
        {
            string a = "";
            double result = 0;

            Console.Write("INGRESAR EL DAÑO BASE : ");
            num1 = ValidoDouble(a);
            Console.Write("INGRESAR EL % de CriticDMG : ");
            num2 = ValidoDouble(a);

            num2 = num2 / 100;
            num2 = num2 + 1;
            result = num2 * num1;

            return result;
        }
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            Console.WriteLine("BIENDENIDOS");
            result = CriticDMG(num1, num2);
            Console.WriteLine("Daño de Golpe critico = "+ result);

        }
        
    }
}
