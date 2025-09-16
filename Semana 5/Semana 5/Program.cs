
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semana_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*
            string linea;
            Console.WriteLine("ingrese el numero clave: "); linea = Console.ReadLine();
            int a = 1;
            int b = 3;
            bool der = false;
            bool primera = false;
            bool segunda = false;
            primera = a == 0 || b == 3;
            segunda = primera && der == false;
            Console.WriteLine(primera);
            Console.WriteLine(segunda);
            return;

            if (a == 1)
            {
                Console.WriteLine("A es correcto");
                Console.ReadKey();
                a = 16;
                Console.WriteLine("A ahora es igual a: " + a);
                Console.ReadKey();
            }
            else if (a != 1)
            {
                Console.WriteLine("Dato invalido, no puede continuar con la operacion...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("error, cerrando consola");
                Console.ReadKey();
            }


            a = 6;
            Console.WriteLine("El resultadode A es = " + a);
            Console.ReadKey();
            */

            int a = 1;
            int b = 2;
            bool der = false;

            if (a == 0)
            {
                if (b == 1)
                {
                    Console.WriteLine("B es igual a: " + b);
                }
                else
                {
                    Console.WriteLine("B es diferente: " + b);
                }
            }
            else
            {
                Console.WriteLine("A es igual a: " + a);
            }

            a = 6
                 
        }
    }
}
