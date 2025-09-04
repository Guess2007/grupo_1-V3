using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Semana_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                double num1, num2;
                double may;
                string linea;
                bool correcto;

                do
                {
                    Console.Write("PRIMER NUMERO: "); linea = Console.ReadLine();
                    correcto = double.TryParse(linea, out num1);
                    if (!correcto)
                    {
                        Console.WriteLine("dato invalido, intente de nuevo");

                    }
                } while (!correcto);

                do
                {
                    Console.Write("SEGUNDO NUMERO: "); linea = Console.ReadLine();
                    correcto = double.TryParse(linea, out num2);
                    if (!correcto)
                    {
                        Console.WriteLine("dato invalido, intente de nuevo");

                    }

                } while (!correcto);


                Console.WriteLine();
                may = num1 > num2 ? num1 : num2;
                Console.WriteLine("el mayor es: " + may); linea = Console.ReadLine();
                Console.WriteLine("presione enter para seguir"); Console.ReadLine();
                Console.ReadKey();

            }


        }
    }
}
