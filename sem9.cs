using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_ABC;

namespace ConsoleApp12
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("ingresa el primer numero ");
            a = Program.ValidoInt(a);
            int b = 0;
            Console.WriteLine("ingresa el segundo numero ");
            b = Program.ValidoInt(b);
           
            int c;
            c = Class1.OperacionesBasicas.suma(a, b);
            Console.WriteLine("suma  = "+c);
            c = Class1.OperacionesBasicas.resta(a, b);
            Console.WriteLine("resta = "+c);
            c = Class1.OperacionesBasicas.producto(a, b);
            Console.WriteLine("producto = "+c);
            c = Class1.OperacionesBasicas.division(a, b);
            Console.WriteLine("division = "+c);
        }
    }
}
