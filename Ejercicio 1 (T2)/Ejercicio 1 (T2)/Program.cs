using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio_1__T2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            int b;
            b = 2;
            do 
            {
                Calcularpar(b);
                calcularImpar(a);
            } while (b >= 50 || a <= 100);

        }
        public static void Calcularpar(int b) 
        { 
            if (b == 2 || b == 4 || b == 6 || b == 8 || b == 10) 
            {
                do
                {
                    int result;
                    result = 2 + 4 + 6 + 8 + 10;
                    for (int i = 50; 1 < result; i++)
                    {
                        result++;
                    }
                } while (b <= 100 || b >= 50);
            }
        }
        public static void calcularImpar(int a)
        {
            if (a == 1 || a == 3 || a == 5 || a == 7 || a == 9)
            {
                do
                {
                    int result;
                    result = 1 * 3 * 5 * 7 * 9;
                    for (int i = 100; 1 < result; i++)
                    {
                        result++;
                    }
                } while (a >= 100 || a >= 200);
            }
        }
    }
}






