using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada1;
            string entrada2;
            
            double num2 = 0 ;
            double num3 = 0 ;
            double num4 = 0 ;
            
            Console.Write("ingresa el numero del que se requiera la tabla : ");
            entrada1 = Console.ReadLine(); num3 = double.Parse(entrada1);
            Console.Write("hasta que numero quiere multiplicar : ");
            entrada2 = Console.ReadLine(); num2 = double.Parse(entrada1);
            
            for (double num1 = 0 ; num1< num2 ; num1++)
            {
                num4 = (num1*num3);
                Console.WriteLine(num1 + "*" + num3 + "= "+ num4 );
            } 




        }
    }
}
