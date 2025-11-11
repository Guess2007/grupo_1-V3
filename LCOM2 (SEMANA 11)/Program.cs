using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LCOM2__SEMANA_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string linea = "";
            int can;
            int pos;
            Random rnd = new Random();

            Console.WriteLine("cuantos random habran en el arreglo: ");
            linea = Console.ReadLine();
            can = int.Parse(linea);
            int[] vec = new int[can+1];
            for (pos = 1; pos <= can; pos++)
            {
                vec[pos] = rnd.Next(0, 99);
            }
            for (pos = 1; pos <= can; pos++) 
            {
                Console.SetCursorPosition(3, pos + 2);
                Console.WriteLine(vec[pos]);
            }
            Console.WriteLine("Pulse una tecla...");
            */

            /*
            char [] a;
            string linea;
            Console.WriteLine("digite una frase: "); linea = Console.ReadLine();
            a = linea.ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }    

            */

            string linea;
            int a = 0;
            Console.WriteLine("Cuantos elementos: "); linea = Console.ReadLine();
            a = int.Parse(linea);

            int[] posicion = new int[a];
            for (int i = 0; i < posicion.Length; i++)
            {
                posicion[i] = Console.WriteLine();
            }


        }
    }
}
