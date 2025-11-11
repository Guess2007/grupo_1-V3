using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lim = 4, ind, num;
            int[]a = new int[lim];

            a[0] = 5;
            a[1] = 10;
            a[2] = 15;
            a[3] = 20;

            Console.WriteLine("Array original:");

            Console.WriteLine("a[{0}] = ", lim);
            for(int i = 0; i <lim;i++)
            {
                Console.WriteLine("[{0}]", a[i]);
            }

            Console.WriteLine("* indice a insertar [0-3]");
            ind = int.Parse(Console.ReadLine());

            Console.WriteLine("* Numero a insertar: ");
            num = int.Parse(Console.ReadLine());

            lim++;
            Array.Resize(ref a, lim);

            for(int i = lim -1;i > ind; i--)
            {
                a[i] = a[i - 1];
            }

            a[ind] = num;

            Console.WriteLine();
            Console.WriteLine("Array nuevo");
            Console.WriteLine("a[{0}] = ", lim);
            for(int i = 0; i < lim; i++)
            {
                Console.WriteLine("[{0}]", a[i]);
            }

            Console.ReadKey();
        }
    }
}
