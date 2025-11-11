using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ENT = new int[4] { 5, 10, 15, 20 };
            int a = 0;
            int b = 0;

            Console.Write("array original: ");
            for (int i = 0; i < ENT.Length; i++)
            {
                Console.Write("[" + ENT[i] + "]");
            }
            Console.WriteLine("");
            Console.Write("ingrese un indice del 1-3: ");
            string linea = Console.ReadLine(); int numA = int.Parse(linea);
            Console.Write("ingrese otro indice para el intercambio: "); 
            string lineb = Console.ReadLine(); int numB = int.Parse(lineb);

            a = ENT[numA];
            b = ENT[numB];
            ENT[numA] = b;
            ENT[numB] = a;

            Console.Write("nuevo array : ");
            for (int i = 0; i < ENT.Length; i++)
            {
                Console.Write("[" + ENT[i] + "]");
            }
        }
    }
}
