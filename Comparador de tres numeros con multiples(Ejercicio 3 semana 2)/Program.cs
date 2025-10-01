using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_semana2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            double mayor;
            double menor;


            do
            {
                Console.WriteLine("Ingrese el primer numero:");
                num1 = double.Parse(Console.ReadLine());
                if (num1 < 0)
                {
                    Console.WriteLine("El numero no puede ser negativo, intente de nuevo.");
                    continue;
                }
                else if (num1 == 0)
                {
                    Console.WriteLine("El numero no puede ser cero, intente de nuevo.");
                    continue;
                }
                else if (!double.TryParse(num1.ToString(), out num1))
                {
                    Console.WriteLine("Entrada invalida, intente de nuevo.");
                    continue;

                }

                do
                {
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = double.Parse(Console.ReadLine());
                    if (num2 < 0)
                    {
                        Console.WriteLine("El numero no puede ser negativo, intente de nuevo.");
                        continue;
                    }
                    else if (num2 == 0)
                    {
                        Console.WriteLine("El numero no puede ser cero, intente de nuevo.");
                        continue;
                    }
                    else if (!double.TryParse(num2.ToString(), out num2))
                    {
                        Console.WriteLine("Entrada invalida, intente de nuevo.");
                        continue;
                    }
                } while (num2 < 0);
                do
                {
                    Console.WriteLine("Ingrese el tercer numero:");
                    num3 = double.Parse(Console.ReadLine());
                    if (num3 < 0)
                    {
                        Console.WriteLine("El numero no puede ser negativo, intente de nuevo.");
                        continue;
                    }
                    else if (num3 == 0)
                    {
                        Console.WriteLine("El numero no puede ser cero, intente de nuevo.");
                        continue;
                    }
                    else if (!double.TryParse(num3.ToString(), out num3))
                    {
                        Console.WriteLine("Entrada invalida, intente de nuevo.");
                        continue;
                    }
                } while (num3 < 0);

            } while (num1 < 0);
            mayor = Math.Max(num1, Math.Max(val1: num2, val2: num3));
            menor = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
            Console.ReadKey();
        }
    }
}
