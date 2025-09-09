using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1_semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double may;
            string linea;

            Console.WriteLine("ingrese el primer numero: "); linea = Console.ReadLine();
            num1 = double.Parse(linea);

            if (num1 != 0 || num1 <= -100 || num1 <= 100)
            {
                Console.WriteLine("ingrese el segundo numero: "); linea = Console.ReadLine();
                num2 = double.Parse(linea);
                if (num2 != 0 || num2 <= -100 || num2 <= 100)
                {
                    Console.WriteLine();
                    may = num1 > num2 ? num1 : num2;
                    Console.WriteLine("el numero mayor: " + may); linea = Console.ReadLine();
                    bool continuar;
                    string respuesta;
                    do
                    {

                        Console.Write("¿Desea continuar? (s/n): "); respuesta = Console.ReadLine();

                        if (respuesta == "s")
                        {
                            continuar = true;
                        }
                        else if (respuesta == "n")
                        {
                            continuar = false;
                        }
                        else
                        {
                            Console.WriteLine("Respuesta invalida. Por favor, intente de nuevo...");
                            continuar = false;
                        }

                    } while (respuesta != "s" && respuesta != "n");
                }
                else 
                {
                    Console.WriteLine("numero ingresado invalido, error, cerrando consola...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("dato invalido, error, cerrando consola");
                Console.ReadKey();
            }
        }
    }
}
