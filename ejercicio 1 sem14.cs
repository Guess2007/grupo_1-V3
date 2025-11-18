using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            string[] b = {"a","b","c","d","e"};

            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write("Ingresar la edad "+i +" :");
                string line = Console.ReadLine(); int num = int.Parse(line);
                a[i] = num; 
                Console.Write("Ingresar el nombre "+i+" :");
                string line2 = Console.ReadLine(); 
                b[i] = line2;
                Console.WriteLine("");
            }
           
            Console.WriteLine("Personas Mayores De Edad");
            
            for (int i = 0; i < b.Length; i++) 
            {
                if (a[i] >= 18 )
                {
                    Console.WriteLine(b[i]);
                }
            } 
        }
    }
}
