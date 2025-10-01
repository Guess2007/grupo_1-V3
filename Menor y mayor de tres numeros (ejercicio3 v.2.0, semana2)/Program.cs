using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_v._2._0__semana2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;
            double menor;
            double mayor;
            string linea;
            bool esValido;

            do
            {
                Console.WriteLine("Ingrese el primer numero: "); linea = Console.ReadLine();
                esValido = double.TryParse(linea, out numero1);
                if (!esValido || 0 > numero1)
                {
                    Console.WriteLine("dato invalido, intente de nuevo");
                }
                
                else if (numero1 == 0)
                {
                    Console.WriteLine("el numero no puede ser igual a cero, intente de nuevo");
                }
            } while (!esValido || 0 > numero1 || numero1 == 0);

            do
            {
                Console.WriteLine("ingrese el segundo numero"); linea = Console.ReadLine();
                esValido = double.TryParse(linea, out numero2);
                if (!esValido || 0 > numero2)
                {
                    Console.WriteLine("dato invalido, intente de nuevo;)");
                }
                
                else if (numero2 == 0)
                {
                    Console.WriteLine("el numero no puede ser igual a cero, intente de nuevo ");
                }
            } while (!esValido || 0 > numero2 || numero2 == 0);

            do
            {
                Console.WriteLine("ingrese el tercer numero"); linea = Console.ReadLine();
                esValido = double.TryParse(linea, out numero3);

                if (!esValido || 0 > numero3)
                {
                    Console.WriteLine("dato invalido, intente de nuevo;)");
                    continue;

                }

                else if (numero3 == 0)
                {
                    Console.WriteLine("el numero no puede ser igual a cero, intente de nuevo ");
                    continue;

                }

            } while (!esValido || 0 > numero3 || numero3 == 0);
            mayor = Math.Max(numero1, Math.Max(val1: numero2, val2: numero3));
            menor = Math.Min(numero1, Math.Min(numero2, numero3));
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
            Console.ReadKey();


        }
    }
}

