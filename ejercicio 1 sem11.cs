using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CAN = 0;
            int POS = 0;
            string linea;
            Random rnd = new Random();
            
            Console.Write("Numero de aleatorios :");
            linea = Console.ReadLine();  CAN = int.Parse(linea);

            double[] VEC = new double[CAN + 1];
            for (POS = 1; POS <= CAN; POS++)
            {
                VEC[POS] = rnd.Next(0, 99);
               
            }
           
            for (POS = 1; POS <= CAN; POS++)
            {
                
                Console.WriteLine(VEC[POS]);

            }




        }
    }
}
