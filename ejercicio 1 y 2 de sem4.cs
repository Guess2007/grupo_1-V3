using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] caracteres;
            string entrada1 ="";
            string entrada2 ="";

            Console.Write("ingrese el número :  ");
            entrada1 = Console.ReadLine();
            caracteres = entrada1.ToCharArray();
            Array.Reverse(caracteres);
            entrada2 = new string(caracteres);
            Console.Write("El numero invertido es : "+entrada2);



        }
    }
}
