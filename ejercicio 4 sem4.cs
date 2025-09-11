using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, d = 0;  // double para ingresar decimales y redondearlos
            double e = 0, f = 0, g = 0;  
            double x = 2;  
            string entrada1;

            Console.Write("ingrese un numero :");
            entrada1 = Console.ReadLine(); a = double.Parse(entrada1);

            b = Math.Sqrt(a); 
            c = Math.Round(a);
            d = Math.Pow(a , x );
            e = Math.Sin(a);
            f = Math.Cos(a);
            
            g = Math.Truncate(a);
            
            Console.WriteLine("Potencia : " + d ); 
            Console.WriteLine("Raiz cuadrada : " + b ); 
            Console.WriteLine("seno : " + e ); 
            Console.WriteLine("coseno : " + f ); 
           
            Console.WriteLine("Parte emtera : " + g ); 
            Console.WriteLine("Redondeo : " + c ); 
            
        }
    }
}
