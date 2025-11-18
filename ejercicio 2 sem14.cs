using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            string[] b = { "a", "b", "c", "d", "e" };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Ingresar el nombre " + i + " :");
                string line2 = Console.ReadLine();
                b[i] = line2;
                Console.Write("Ingresar el sueldo " + i + " :");
                string line = Console.ReadLine(); int num = int.Parse(line);
                a[i] = num;
                
                Console.WriteLine("");
            }

            Console.Write("El operario con mayor sueldo gana : ");

            int mayor = Math.Max(a[4],Math.Max(a[3],Math.Max(a[2], Math.Max(a[0], a[1]))));

            Console.Write("s/ "+mayor);
            Console.WriteLine("");
        }
    }
}
