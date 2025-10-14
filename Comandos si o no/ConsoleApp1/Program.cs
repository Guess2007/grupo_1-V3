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
            char s, v;
            int n1, n2, n3;
            string linea;
            bool esVocal;

            do
            {
                Console.WriteLine("Ingrese una letra"); linea = Console.ReadLine();
                esVocal = int.TryParse(linea, out n1);
                if (!esVocal)
                {
                    s = Convert.ToChar(linea);
                    v = Char.ToLower(s);
                    if ((v == 'a') || (v == 'e') || (v == 'i') || (v == 'o') || (v == 'u'))
                        Console.WriteLine("Es una vocal");
                    else
                        Console.WriteLine("No es una vocal");
                }
                else
                    Console.WriteLine("No es una letra");
            } while (!esVocal);

            do 
            {
                Console.WriteLine("fin del programa, ¿Desea continuar? (s/n)");
                linea = Console.ReadLine();
                s = Convert.ToChar(linea);
                v = char.ToLower(s);

            }while (v != 's' && v != 'n');

        }
    }
}
