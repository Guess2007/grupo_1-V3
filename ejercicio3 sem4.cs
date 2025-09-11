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
            string entrada1;
            string entrada2;
            int Num1 = 0;
            int Num2 = 0;
            double a = 0 ,b = 0,c = 0,d = 0,e = 0;
            
            Console.Write("ingrese el primer numero : ");  
            entrada1 = Console.ReadLine();Num1 = int.Parse(entrada1);
            Console.Write("ingrese el segundo numero : ");  
            entrada2 = Console.ReadLine();Num2 = int.Parse(entrada2);

            a = Num1 + Num2;
            b = Num1 - Num2;
            c = Num1 * Num2;
            d = Num1 / Num2;
            e = Num1 % Num2;

            Console.WriteLine("La suma es :" + a);
            Console.WriteLine("La resta es :" + b);
            Console.WriteLine("La multiplicación es :" + c);
            Console.WriteLine("La division :" + d);
            Console.WriteLine("El residuo es :" + e);
        }
    }
}
