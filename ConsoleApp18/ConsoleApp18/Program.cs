using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR FILAS Y COLUMNAS
            Console.WriteLine("Ingrese la cantidad de filas:");
            int filas=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de columnas: ");
            int columnas=int.Parse(Console.ReadLine());

            //CREACION DE MATRIZ CON FILAS Y COLUMNAS
            int[,]matriz=new int[filas,columnas];

            for(int i = 0; i <filas; i++)
            {
                for(int j = 0; j <columnas; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}]:");
                    matriz[i,j]=int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j]+ "\t");  //ALINEAR
                }
                Console.WriteLine(); //SALTO DE LINEA
            }

            Console.WriteLine("FIN DEL PROGRAMA");


        }
    }
}
