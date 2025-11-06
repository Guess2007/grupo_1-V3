using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCOM2_1._1__Semana_12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux;

            Console.WriteLine("¿Cuantos elementos? (maximo: 12) ");
            aux = int.Parse(Console.ReadLine());
            do 
            {
                if (aux <= 12)
                {
                    int[] lista = new int[aux];

                    for (int i = 0; i < aux; i++)
                    {
                        int num = 0;
                        Console.WriteLine("posicion " + i + ": ");
                        num = int.Parse(Console.ReadLine());
                        lista[i] = num;
                    }

                }
                else 
                {
                    Console.WriteLine("Fuera de los parametros, intente de nuevo...");
                    Console.ReadKey();
                }
                
            } while (aux > 12);

            

            
        }
    }
}
