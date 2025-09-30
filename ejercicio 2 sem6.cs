using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            if (numero == 2)
            {
                return true;
            }
            if (numero % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int num = 0;
            string a;
            bool b;
            do 
            {
                Console.WriteLine("ingresa un numero : ");
                a = Console.ReadLine(); b= int.TryParse(a, out num);
                if (!b) 
                {
                    Console.WriteLine("INGRESA UN DATO VALIDO");
                }

            } while (!b);
            

            if (EsPrimo(num))
            {
                Console.WriteLine($"{num} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{num} no es un número primo.");
            }


        }
    }
}
