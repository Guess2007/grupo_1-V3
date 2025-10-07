using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_la_semana_8
{
    internal class calculos
    {
        int numero, potencia, resultado;

        public void calcularfactorial()
        {
            string linea;
            Console.WriteLine("ingrese un numero: "); linea = Console.ReadLine();
            numero = int.Parse(linea);
            resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("el factorial es: " + resultado);
            Console.ReadKey();
        }
        public void calcularpotencia()
        {
            string linea;
            Console.WriteLine("ingrese un numero: "); linea = Console.ReadLine();
            numero = int.Parse(linea);
            Console.WriteLine("ingrese la potencia: "); linea = Console.ReadLine();
            potencia = int.Parse(linea);
            resultado = 1;
            for (int i = 1; i <= potencia; i++)
            {
                resultado = resultado * numero;
            }
            Console.WriteLine("el resultado es: " + resultado);
            Console.ReadKey();
        }
        public void compararnumeros()
        {
            double numero1, numero2, numero3, intermedio, mayor, menor;
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
            mayor = Math.Max(numero1, Math.Max(numero2, numero3));
            menor = Math.Min(numero1, Math.Min(numero2, numero3));
            Console.WriteLine("el numero mayor es: " + mayor);
            Console.WriteLine("el numero menor es: " + menor);
            Console.ReadKey();
        }
    }
}
