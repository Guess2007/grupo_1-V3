using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__T2_
{
    internal class Par
    {
        public static void Calcularpar(int a)
        {
            if (a == 2 || a == 4 || a == 6 || a == 8 || a == 10)
            {
                int result;
                result = a + a;
                do
                {
                    for (int i = 0; i < result; i++)
                    {
                        result++;
                    }
                } while (result >= 50 && result <= 100);

            }
            else
            {
                Console.WriteLine("el numero ingresado no corresponde a la serie de numeros par");
            }
        }
    }
}
