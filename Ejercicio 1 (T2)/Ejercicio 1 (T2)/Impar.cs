using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__T2_
{
    internal class Impar
    {
        public static void calcularimpar(int a)
        {
            if (a == 1 || a == 3 || a == 5 || a == 7 || a == 9)
            {
                int result;
                result = 1 * 3 * 5 * 7 * 9;
                do
                {
                    for (int i = 0; i < result; i++)
                    {
                        result++;
                    }
                } while (result >= 100);

            }
            else
            {
                Console.WriteLine("el numero ingresado no corresponde a la serie de numeros par");
            }
        }
    }
}
