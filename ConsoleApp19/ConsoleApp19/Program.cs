using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DECLARAR MATRZ PARA DIAGONAL (NXN)
            Console.WriteLine("Ingrese el tamaño de la matriz:");
            int n = int.Parse(Console.ReadLine());

            //CREACION DE MATRIZ CON FILAS Y COLUMNAS

            int[,] matriz = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //IMPRIMIR MATRIZ DIAGONAL
            Console.WriteLine("\n DIAGONAL PRINCIPAL");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + "\t");
            }
            Console.WriteLine("Fin del programa.");

        }
    }
}
