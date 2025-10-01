using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_semana_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operacion;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion a realizar (+, -, *, /)");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("El resultado de la multiplicacion es: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine("El resultado de la division es: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operacion no valida.");
                    break; 
            }
        }
    }
}
