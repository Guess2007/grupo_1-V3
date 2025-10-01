using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4__semana_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            string operacion;
            long resultado=0;

            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            resultado = Math.Abs((long)num1);

            Console.WriteLine("El valor absoluto es: " + resultado);
            Console.WriteLine("La potencia del numero es: " + Math.Pow(num1, 2));
            Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(num1));
            Console.WriteLine("El numero maximo es: " + Math.Max(num1, resultado));
            Console.WriteLine("El numero minimo es: " + Math.Min(num1, resultado));
            Console.WriteLine("El numero redondeado es: " + Math.Round(num1));
            Math.Truncate(num1);
            Console.WriteLine("El numero truncado es: " + Math.Truncate(num1));
            Console.WriteLine("El numero entero es: " + Math.Floor(num1));
            Console.ReadKey();
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();


        }
    }
}
