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

            int[] ENT = new int[4] { 5, 10,15,20 };
            int[] ENT2 = new int[ENT.Length + 1];
            
            for (int i = 0; i < ENT.Length; i++)
            {
                ENT2[i] = ENT[i];
                if (i +1 == ENT.Length )
                {
                    ENT2[i+1] = 100;
                }
                
            }
            for (int i = 0; i < ENT2.Length; i++)
            { 
                Console.WriteLine(ENT2[i]);
            }
        }
    }
}
