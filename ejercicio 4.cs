using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int[] ENT = new int[5] { 5, 10, 100, 15, 20 };
            int[] ENT2 = new int[ENT.Length - 1];
            Console.Write("array original: ");
            for (int i = 0; i < ENT.Length; i++)
            {
                Console.Write("[" + ENT[i] + "]");
            }
            Console.WriteLine("");
            Console.Write("ingrese un indice para eliminar, del 1-3: ");
            string linea = Console.ReadLine(); int numA = int.Parse(linea);
            ENT[numA] = 0;
            a = ENT[numA];
            b = ENT[ENT.Length-1];
            ENT[numA] = b;
            ENT[ENT.Length-1] = a;

            for (int i = 0; i < ENT.Length-1; i++)
            {
                ENT2[i] = ENT[i];
            }
            Console.Write("nuevo array : ");
            for (int i = 0; i < ENT2.Length; i++)
            {
                Console.Write("[" + ENT2[i] + "]");
            }
        }
    }
}
