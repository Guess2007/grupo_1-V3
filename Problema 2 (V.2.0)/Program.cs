using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2__V._2._0_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool esMayor = num1 < num2;
            Console.WriteLine($"el numero mayor es" + esMayor);

        }
    }
}
