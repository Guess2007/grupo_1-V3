using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el monto de la compra");
            int num = int.Parse(Console.ReadLine());

            if (num > 200)
            {
                Console.WriteLine("Obtuvo descuento de 10% por la compra");
            }

            else
            {
                Console.WriteLine("obtuvo descuento de 5% por la compra");
            }
            
           
        }
    }
}
