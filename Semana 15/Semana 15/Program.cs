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
            matriz2();
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
                //Paso 1: la consola pide al usuario las caracteristicas del array.
                a = new int[fila, columna];//array que almacena los datos ingresados por el usuario.
                Console.WriteLine("\ningrese los valores de su matriz: ");
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)//Tanto el for i como el for j se encargaran de hacer un bucle para que el usuario vaya llenando los espacios del array hasta que i sea igual al numero columnas y j el numero de filas
                    {
                        Console.Write("a[{0},{1}]: ", i, j);
                        a[i, j] = int.Parse(Console.ReadLine());//Mientras que este ira almacenando lo que vaya escribiendo el usuario en el bucle
                    }
                }
                Console.Write("*Matriz a[{0},{1}]: \n", fila, columna);
                //Escribir la matriz actual
                for (int i = 0; i < fila; i++) 
                {
                    for (int j = 0;j < columna; j++) 
                    {
                        Console.Write("[{0}]  ", a[i,j]);//En comparacion al for anterior, este for se encargara de imprimir la matriz hasta que, nuevamente, i iguale el numero de filas, y j el numero de columnas
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            } 
        }
        public static void matriz1() 
        { 
            {
                int[,] a = { { 1, 2, 3},
                             { 4, 5, 6},
                             { 7, 8, 9}};
                int t_f = a.GetLength(0);//operador encargado de obtener el largo de las filas
                int t_c = a.GetLength(1);//operador encargado de obtener el largo de las columnnas
                Console.WriteLine("\n* Matriz a[{0},{1}]: ", t_f, t_c);
                for (int i = 0; i < t_f; i++)//bucle encargado de que el .write escriba las filas de la matriz hasta llegar a su limite
                {
                    for (int j = 0; j < t_c; j++)//bucle encargado de que el .write escriba las columnas de la matriz hasta llegar a su limite
                    {
                        Console.Write("[{0}] ", a[i, j]);//.Write encargado de escribir la matriz inicial en base al bucle for de i y j
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n* Diagonal principal:");
                for (int i = 0; i < t_f; i++)
                {
                    for (int j = 0; j < t_c; j++)
                    {
                        if (i == j)//if que sirve para que el bucle for solo escriba las ubicaciones de misma ubicacion en fila y columna
                        {
                            Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                        }
                    }
                }
                Console.ReadKey();
            } 
        }
        public static void matriz2() 
        { 
            {
                int[,] a = { { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 }};
                int t_f = a.GetLength(0);//operador encargado de obtener el largo de las filas
                int t_c = a.GetLength(1);//operador encargado de obtener el largo de las columnnas
                Console.WriteLine("\n* Matriz a[{0},{1}]: ", t_f, t_c);
                for (int i = 0; i < t_f; i++)//bucle encargado de que el .write escriba las filas de la matriz hasta llegar a su limite
                {
                    for (int j = 0; j < t_c; j++)//bucle encargado de que el .write escriba las columnas de la matriz hasta llegar a su limite
                    {
                        Console.Write("[{0}] ", a[i, j]);//.Write encargado de escribir la matriz inicial en base al bucle for de i y j
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n* Diagonal inversa:");
                for (int i = 0; i < t_f; i++)
                {
                    Console.WriteLine("a[{0},{1}]={2}",i, t_f - i - 1, a[i, t_f - i - 1]);//en el caso de estas dos formulas, estas nos sirven para poder ajustar lo que se va a mostrar en el array
                }
                Console.ReadKey();
                a[0,0]+ a[0,1] + a[0,2]=prom
                    prom/a.GetLength = prom1
                    console.Writeline("promedio semana 1:")
                    console.Writeline("repartido 1: prom1")
            } 
        }
    }
}
