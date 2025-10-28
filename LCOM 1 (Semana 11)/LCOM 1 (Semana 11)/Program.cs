using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LCOM_1__Semana_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[20];
            datos = new int[] {1, 2, 3, 4, 5, 6 };
            Console.Write(datos.Length);
            int[] edades = new int[10];
            edades[0] = 10;
            edades[1] = 35;
            edades[2] = 48;
            edades[3] = 09;
            edades[4] = 95;
            edades[5] = 152;
            edades[6] = 68;
            edades[7] = 48;
            edades[8] = 18;
            edades[9] = 13;

            string var1 = "";
            Console.WriteLine("AGREGAR LONGITUD: ");
            var1 = Console.ReadLine();
            int[] edades1 = new int[int.Parse(var1)];
            int[] notas = { 12, 08, 09, 05, 18, 19, 20 };
            string[] paises = { "Peru", "Brazil", "Colombia", "Ecuador", "Chile", "Mexico", "Bolivia" };
            double[] precios = { 12.12, 34.5, 12.2, 34.3, 52.2, 42.8 };
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("El tamaño del array vocales es: " + vocales.Length);
            Console.WriteLine("El tamaño del array precios es: " + precios.Length);
            Console.WriteLine("El tamaño del array paises es: " + paises.Length);
            Console.WriteLine("El tamaño del array edades es: " + edades1.Length);
            Console.WriteLine("El tamaño del array notas es: " + notas.Length);
            Console.WriteLine("La edad del numero x es: " + edades[2]);
            Console.WriteLine("El indice 7 es: " + paises[6]);
            for (int i = 0; i < edades.Length; i++) 
            {
                Console.WriteLine(edades[i]);
            }
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine(notas[i]);
            }
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine(precios[i]);
            }
            for (int i = 0; i < vocales.Length; i++)
            {
                Console.WriteLine(vocales[i]);
            }
        }
    }
}
