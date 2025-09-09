using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_semana2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3, intermedio;
            string linea;
            bool esNumero;

                do
                {
                    Console.WriteLine("Ingrese el primer numero: "); linea = Console.ReadLine();
                    esNumero = double.TryParse(linea, out numero1);
                    if (!esNumero || 0 > numero1)
                    {
                        Console.WriteLine("dato invalido, intente de nuevo");
                    }

                    else if (numero1 == 0)
                    {
                        Console.WriteLine("el numero no puede ser igual a cero, intente de nuevo");
                    }
                } while (!esNumero || 0 > numero1 || numero1 == 0);

                do
                {
                    Console.WriteLine("ingrese el segundo numero"); linea = Console.ReadLine();
                    esNumero = double.TryParse(linea, out numero2);
                    if (!esNumero || 0 > numero2)
                    {
                        Console.WriteLine("dato invalido, intente de nuevo;)");
                    }

                    else if (numero2 == 0)
                    {
                        Console.WriteLine("el numero no puede ser igual a cero, intente de nuevo ");
                    }
                } while (!esNumero || 0 > numero2 || numero2 == 0);

                do
                {
                    Console.WriteLine("ingrese el tercer numero"); linea = Console.ReadLine();
                    esNumero = double.TryParse(linea, out numero3);

                    if (!esNumero || 0 > numero3)
                    {
                        Console.WriteLine("dato invalido, intente de nuevo;)");
                        continue;

                    }

                    else if (numero3 == 0)
                    {
                        Console.WriteLine("el numero no puede ser igual a cero, intente de nuevo ");
                        continue;

                    }

                } while (!esNumero || 0 > numero3 || numero3 == 0);
                if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
                {
                    Console.WriteLine("los numeros no pueden ser iguales, intente de nuevo");
                } while (numero1 == numero2 || numero1 == numero3 || numero2 == numero3) ;
                if ((numero1 > numero2 && numero1 < numero3) || (numero1 < numero2 && numero1 > numero3))
                {
                    intermedio = numero1;
                    Console.WriteLine("el numero intermedio es: " + intermedio);
                }
                else if ((numero2 > numero1 && numero2 < numero3) || (numero2 < numero1 && numero2 > numero3))
                {
                    intermedio = numero2;
                    Console.WriteLine("el numero intermedio es: " + intermedio);
                }
                else
                {
                    intermedio = numero3;
                    Console.WriteLine("el numero intermedio es: " + intermedio);
            }
                Console.ReadKey();
        }
    }
}

            
        
    

