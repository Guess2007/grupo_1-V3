using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] ENT = new int[4] {5,10,15,20 };
            int[] ENT2 = new int[ENT.Length + 1];
            Console.Write("Array original :\n ent[4] = ");
            for (int i = 0; i < ENT.Length; i++) 
            {
                Console.Write("["+ENT[i]+"]");
            }
            Console.WriteLine("\n ");
            Console.Write("ingrese el indice numero (2): " );
            string linea = Console.ReadLine(); int numA = int.Parse(linea);
            Console.Write("igrese el numero (100): ");
            
            string lineb = Console.ReadLine(); int numB = int.Parse(lineb);

            
            
            for (int i = 0; i < ENT.Length+1; i++)
            {

                if (i == numA)
                {

                }
                else if (i== 3 ) 
                {
                    ENT2[3] = ENT[2];
                }
                else if (i== 4 ) 
                {
                    ENT2[4] = ENT[3];
                }
                
                else
                {
                    ENT2[i] = ENT[i];
                }
               
                
            }
            ENT2[numA] = numB;
            Console.WriteLine("el nuevo array es : ");
            for (int i = 0; i < ENT2.Length; i++) 
            {
                Console.Write("["+ENT2[i]+"]");
            }
          
        }
    }
}
