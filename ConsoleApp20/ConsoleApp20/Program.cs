using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARAR MATRIZ A (NXN)
            Console.WriteLine("Ingrese el tamaño de la matriz A Y B:");
            int n = int.Parse(Console.ReadLine());

            //CREACION DE MATRICES CON FILAS Y COLUMNAS (MISMO TAMAÑO)

            int[,] matrizA = new int[n, n];
            int[,] matrizB = new int[n, n];
            int[,] matrizC = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.WriteLine();
                    Console.Write(matrizC[i, j]);
                }
            }
        }
    }
}
