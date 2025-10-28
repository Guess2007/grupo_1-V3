using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3__T2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;

            Console.WriteLine("Ingrese el primer numero: "); linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese el segundo numero: "); linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese el tercer numero: "); linea = Console.ReadLine();
            num3 = int.Parse(linea);
            mayor(num1, num2, num3);
            menor(num1, num2, num3);
            promedio(num1, num2, num3);

        }
        public static void mayor(int num1, int num2, int num3) 
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            else if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }
            else if (num1 < num2 && num2 > num3)
            {
                Console.WriteLine("El numero mayor es " + num2);
            }
        }
        public static void menor(int num1, int num2, int num3)
        {
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("El numero menor es: " + num3);
            }
            else if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("El numero menor es: " + num1);
            }
            else
            {
                Console.WriteLine("El numero menor es " + num2);
            }
        }
        public static void promedio(int num1, int num2, int num3) 
        {
            int result, may;
            result = num1 + num2 + num3;
            may = result / 3;
            Console.WriteLine("El promedio es " + may);
        }
    }
}
