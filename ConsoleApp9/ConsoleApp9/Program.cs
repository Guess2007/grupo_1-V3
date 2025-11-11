using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine(".......ingrese calificacion de 0 a 100.......");
            Console.WriteLine("ingreso de nota 1");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingreso de nota 2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingreso de nota 3");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingreso de not4");
            n4=int.Parse(Console.ReadLine());

            double promedio = (n1 + n2 + n3 + n4) / 4.0;
            Console.WriteLine($"promedio : {promedio}");

            string esc;

            if (promedio >= 90 && promedio <= 100)
                esc = "A";
            else if (promedio >= 80)
                esc = "B";
            else if (promedio >= 70)
                esc = "C";
            else if (promedio >= 60)
                esc = "D";
            else
                esc = "E";


            Console.WriteLine($"Escala obteniada: {esc}");  






        }
    }
}
