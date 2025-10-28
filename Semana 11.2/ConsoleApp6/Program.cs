using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string ent;

            Console.Write(" ingresar el tamaño del array: ");
            ent = Console.ReadLine(); num = int.Parse(ent);

            int[] notas = new int[num];

            Console.WriteLine("el tamaño de NOTAS es :" + notas.Length);

            for (int i = 0; i < num; i++)
            {
                string ent1 = "";
                int num1 = 0;
                Console.Write("ingresa el valor de la casilla: ");
                ent1 = Console.ReadLine(); num1 = int.Parse(ent1);
                notas[i] = num1;

            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("el valor de la casilla " + i + " es: " + notas[i]);

            }

        }
    }
}
