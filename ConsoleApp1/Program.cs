using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0;
            double numero2 = 0;
            double numero3 = 0;
            bool correcto;


            do
            {
                Console.Write("Ingrese el primer número: ");
                string entrada1 = Console.ReadLine();
                correcto = double.TryParse(entrada1, out numero1);

                if (!correcto)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
            } while (!correcto);


            do
            {
                Console.Write("Ingrese el segundo número: ");
                string entrada2 = Console.ReadLine();
                correcto = double.TryParse(entrada2, out numero2);

                if (!correcto)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido .");
                }
            } while (!correcto);


            do
            {
                Console.Write("Ingrese el tercer número: ");
                string entrada3 = Console.ReadLine();
                correcto = double.TryParse(entrada3, out numero3);

                if (!correcto)
                {
                    Console.WriteLine(" Entrada inválida. Por favor, ingrese un número válido .");
                }
            } while (!correcto);


            double intermedio;

            bool esIntermedio1 = (numero1 > numero2 && numero1 < numero3) || (numero1 < numero2 && numero1 > numero3);
            bool esIntermedio2 = (numero2 > numero1 && numero2 < numero3) || (numero2 < numero1 && numero2 > numero3);
            bool esIntermedio3 = (numero3 > numero1 && numero3 < numero2) || (numero3 < numero1 && numero3 > numero2);

            if (esIntermedio1)
            {
                intermedio = numero1;
            }
            else if (esIntermedio2)
            {
                intermedio = numero2;
            }
            else
            {
                intermedio = numero3;
            }


            Console.WriteLine("El número intermedio es: " + intermedio);
        }
    }
}
