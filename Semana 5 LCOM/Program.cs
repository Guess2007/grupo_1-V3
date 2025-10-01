using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5_LCOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 40; i <= 100; i ++) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Pulse para finalizar");
            Console.ReadLine();
            */

            
            byte num, i;
            int RESULT;
            string linea;

            Console.WriteLine("Ingrese un numero entero: "); linea = Console.ReadLine();
            num = byte.Parse(linea);
            Console.WriteLine();

            for (i = 100; i >= 1; i--)
            {
                RESULT = num * i;
                Console.WriteLine(num + "*" + i + "=" + RESULT);
            }
            Console.WriteLine("Gracias por usar el programa Csharp");
            Console.ReadKey();
            

            /*
            byte num, I;
            int SUM1 = 0, SUM2 = 0;
            string linea;

            Console.WriteLine("Ingrese un numero entero"); linea = Console.ReadLine();
            num = byte.Parse(linea);
            Console.WriteLine();

            for (int i = 0; i < num; i++)
            {
                SUM1 = i + SUM1;
            }
            for (int i = 0; i < num; i++)
            {
                SUM2 = i + SUM2;
            }
            Console.WriteLine("Total en pares: " + SUM2);
            Console.WriteLine("Total en impares: " + SUM1);
            Console.WriteLine($"{SUM1} {SUM2}");
            Console.Read();
            */
        }
    }
}
