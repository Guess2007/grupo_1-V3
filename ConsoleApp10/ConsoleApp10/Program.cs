using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 5, 10, 15, 20 };
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("indice inicial " + i + ": " + n[i]);
            }

            Array.Resize(ref n, n.Length + 1);
            n[4] = 100;
            Console.WriteLine("\n");
            Console.WriteLine("*********************");
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("indice actual " + i + ": " + n[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("********************************");

            int[] n2 = { 5, 10, 15, 20 };
            int a, b;

            for (int i = 0; i < n2.Length; i++)
            {
                Console.WriteLine("indice actual " + i + ": " + n2[i]);
            }

            Console.WriteLine("indice a insertar [0 - 3]: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("indique numero a insertar: ");
            b = int.Parse(Console.ReadLine());

            Array.Resize(ref n2, n2.Length + 1);
            
            int c = n2[0];
            n2[0] = n2[1];
            n2[1] = n2[2];
            n2[2] = n2[3];
            n2[3] = c;   
            n2[a] = b;

            for (int i = 0; i < n2.Length; i++)
            {               
                Console.WriteLine("indice actual " + i + ": " + n2[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("************************************");

            int[] n3 = { 5, 10, 15, 20, 25 };
            int a1, b1;
            for (int i = 0; i < n3.Length; i++)
            {
                Console.WriteLine("indice " + i + ": " + n3[i]);
            }
            Console.WriteLine("indice 1 a intercambiar [0 - 4]: ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("indice 2 a intercambiar [0 - 4]: ");
            b1 = int.Parse(Console.ReadLine());

            int c1 = n3[a1];
            n3[a1] = n3[b1];
            n3[b1] = c1;

            for (int i = 0; i < n3.Length; i++)
            {
                Console.WriteLine("indice " + i + ": " + n3[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("************************************");
            int[] n4 = { 5, 10, 100, 15, 20 };
            int a2;
            for (int i = 0; i < n4.Length; i++)
            {
                Console.WriteLine("indice " + i + ": " + n4[i]);
            }
            Console.WriteLine("indice a eliminar: ");
            a2 = int.Parse(Console.ReadLine());
                        
            for (int i = 0; i < n4.Length; i++) 
            {
                int c2 = n4[a2];
                n4[a2] = n4[3];
                n4[3] = c2;
                Array.Resize(ref n4, n4.Length - 1);
                Console.WriteLine("indice " + i + ": " + n4[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("************************************");

            int[] n5 = { 45, 17, 23, 67, 21 };
            for (int i = 0; i < n5.Length; i++) 
            {
                Console.WriteLine("indice " + i + ": " + n5[i]);
            }
            Console.WriteLine("------------------------------------");
            Array.Sort(n5);
            for (int i = 0; i < n5.Length; i++) 
            {
                Console.WriteLine("indice " + i + ": " +  n5[i]);
            }
        }

        
    }
}
