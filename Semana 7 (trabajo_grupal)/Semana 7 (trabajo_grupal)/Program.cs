



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7__trabajo_grupal_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            bool esValido;

            Console.WriteLine("ingrese su numero: "); linea = Console.ReadLine();
            esValido = int.TryParse(linea, out num);

            if (!esValido)
            {
                Console.WriteLine("comando invalido, intente de nuevo");
                Console.ReadKey();
            }
            else
            {
                while (num < 10)
                {
                    Console.WriteLine("estos son tus numeros: {0}", num);
                    num+ 











































                }
            }
        }
    }
}
