using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__T2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            string linea;
            
            Console.WriteLine("ingresar limite: "); linea = Console.ReadLine();
            num = int.Parse(linea);
            dp resultA = Calculo(num);
            Console.WriteLine();
            Console.WriteLine("fin del programa..."); Console.ReadKey();
        }
        public static void Calculo (int num) 
        {
            double resultA;
            double resultB;
            double resultC;
            resultA = Math.Pow(num, num);
            resultB = Math.Sqrt(num);
            resultC = resultA / resultB;
        }
    }
}
