using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void imprimir(int[] a)
        {
            int size = a.Length;
            Console.Write("a[{0}] = ", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write("[{0}]", a[i]);
            }
        }
        static void invertir(int[] a)
        {
            int aux;
            int size = a.Length;
            for (int i = 0; i < size / 2; i++)
            {
                aux = a[i];
                a[i] = a[size - i - 1];
                a[size - i - 1] = aux;
            }
        }
        static int[] ingreso()
        {
            int[] a; int size;
            Console.Write("Ingresar tamaño del array: ");
            size = int.Parse(Console.ReadLine());
            a = new int[size];
            Console.WriteLine("\nIngresar datos al array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[] a;
            a = ingreso();
            invertir(a);
            Console.WriteLine("\nImpresión de datos del array:");
            imprimir(a);
            Console.ReadKey();
        }
    }
}
