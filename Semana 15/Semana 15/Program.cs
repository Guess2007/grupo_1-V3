using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            matriz1();
        }
        public static void matriz0() 
        { 
            {
                int[,] a;
                int fila, columna;
                Console.Write("ingrese el numero de columnas: ");
                columna = int.Parse(Console.ReadLine());
                Console.Write("ingrese el numero de filas: ");
                fila = int.Parse(Console.ReadLine());

                a = new int[fila, columna];
                Console.WriteLine("\ningrese los valores de su matriz: ");
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        Console.Write("a[{0},{1}]: ", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            } 
        }
        public static void matriz1() 
        { 
            {
                int[,] a = { { 1, 2, 3},
                             { 4, 5, 6},
                             { 7, 8, 9}};
                int t_f = a.GetLength(0);
                int t_c = a.GetLength(1);
                Console.WriteLine("\n* Matriz a[{0},{1}]: ", t_f, t_c);
                for (int i = 0; i < t_f; i++)
                {
                    for (int j = 0; j < t_c; j++)
                    {
                        Console.Write("[{0}] ", a[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n* Diagonal principal:");
                for (int i = 0; i < t_f; i++)
                {
                    for (int j = 0; j < t_c; j++)
                    {
                        if (i == j)
                        {
                            Console.WriteLine("a[{0},{1}] = {2}",
                            i, j, a[i, j]);
                        }
                    }
                }
                Console.ReadKey();
            } 
        }
        public static void matriz2() 
        { 
            {
            } 
        }
    }
}
