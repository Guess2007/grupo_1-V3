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
            byte num1, num2;
            double may;
            string linea;

            Console.Write("PRIMER NUMERO: -"); linea = Console.ReadLine();
            num1 = byte.Parse(linea);
            Console.Write("SEGUNDO NUMERO: "); linea = Console.ReadLine();
            num2 = byte.Parse(linea);
            Console.WriteLine();
            may = num1 > num2 ? num1 : num2;
            Console.WriteLine("el mayor es: " + may); linea = Console.ReadLine();
            Console.WriteLine(may);
            ConsoleKeyInfo pressedKey = Console.ReadKey();
     
        }
    }
}
