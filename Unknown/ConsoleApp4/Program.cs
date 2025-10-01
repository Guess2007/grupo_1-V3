using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, suma = 0;
            Console.WriteLine("Ingresa un 0 para detener");
            n1 = int.Parse(Console.ReadLine());

            while (n1 != 0)
            {
                suma = suma + n1;
                Console.WriteLine("Ingresa un 0 para detener");
                n1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma total es : " + suma);
        }
    }
}
