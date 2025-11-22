using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCOM1._2__SEMANA_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            int i2 = 0;
            int[] array = new int[5] { 5, 10, 15, 20, 25 };
            Console.WriteLine("array antiguo y tamaño: " + array.Length);
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine("[" + i + "]=" + array[i] + " " );
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("agregar el indice a intercambiar 1: ");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("agregar el indice a intercambiar 2: ");
            i2 = int.Parse(Console.ReadLine());

            int aux = array[i1];
            array[i1] = array[i2];
            array[i2] = aux;
            Console.WriteLine("Array Nuevo y tamaño: " + array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[" + i + "]=" + array[i] + " ");
            }
        }
    }
}
