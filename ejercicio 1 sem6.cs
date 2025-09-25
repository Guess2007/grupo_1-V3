using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ent;
            string ent1;
            
            double num;
            double num1;
            double res;
            double A = 1;
            bool valid;

            do
            {
                Console.Write("ingresar el numero de la tabla : ");
                ent = Console.ReadLine(); valid = double.TryParse(ent,out num);
                if (!valid)
                {
                    Console.WriteLine("INGRESE UN DATO VALIDO");
                }

            } while (!valid);
            do
            {
                Console.Write("¿hasta que numero quiere multiplicar? : ");
                ent1 = Console.ReadLine(); num1 = double.Parse(ent1);
                if (!valid)
                {
                    Console.WriteLine("INGRESE UN DATO VALIDO");
                }

            } while (!valid);

            Console.WriteLine();

            while ( A <= num1 )
            {
                res = A * num;
                Console.WriteLine(" {0} * {1} = {2}", A, num,res);
                A++;
            }
           
            
        }
    }
}
