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
            char[] caracteres;
            string entrada1 = "";
            int num1 = 0;

            Console.Write("ingrese el texto :  ");
            entrada1 = Console.ReadLine(); 
            caracteres = entrada1.ToCharArray();
            num1 = caracteres.Length;
            for (int i = 0; i < num1; i++)
            {
                Console.WriteLine( caracteres[i]);

            }
        }
    }
}
