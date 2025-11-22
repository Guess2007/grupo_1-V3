using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCOM1__SEMANA_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglos = new int[4] { 5, 10, 15, 20 };

            int ind = 0;

            int num = 0;



            Console.WriteLine("Elementos del arreglo Antiguo y Tamaño: " + arreglos.Length);

            for (int i = 0; i < arreglos.Length; i++)

            {

                Console.WriteLine("Elemento " + i + ": " + arreglos[i]);

            }



            Console.Write("Indice a insertar [0-3]: ");

            ind = int.Parse(Console.ReadLine());

            Console.Write("Número a insertar: ");

            num = int.Parse(Console.ReadLine());



            Array.Resize(ref arreglos, 5);



            for (int i = 4; i > ind; i--)
            {

                arreglos[i] = arreglos[i - 1];

            }



            arreglos[ind] = num;



            Console.WriteLine("Elementos del arreglo Nuevo y Tamaño: " + arreglos.Length);

            for (int i = 0; i < arreglos.Length; i++)

            {

                Console.WriteLine("Elemento " + i + ": " + arreglos[i]);



            }
        }
    }
}
