using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCOM_1._3__SEMANA_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eliminar = 0;
            int[] array = { 5, 10, 15, 20, 25};
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine($"[{i}]: {array[i]}");
            }
            Console.WriteLine("ingresar indice a eliminar: ");
            eliminar = int.Parse( Console.ReadLine() );

            for (int i = 0;i < array.Length; i++) 
            {
                if (1 == eliminar) 
                {
                    for (int j = eliminar; j < array.Length - 1; j++) 
                    {
                        array[j] = array[j + 1];
                    }
                }
            }
            Array.Resize(ref array, 4);
            Console.WriteLine("array modificado: ");
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine($"[{i}]: {array[i]}");
            }
            Console.WriteLine("presione enter...");
            Console.ReadKey();
        }
    }
}
