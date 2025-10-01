using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando_para_añadir_el_si_o_no__analizar_profundamente_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char c, d, s, v;
            string linea;
            bool esletra;

            do
            {
                Console.Write("Ingrese un caracter: ");
                linea = Console.ReadLine();
                c = Convert.ToChar(linea);
                esletra = char.IsLetter(c);
                if (esletra)
                {
                    d = char.ToLower(c);
                    switch (d)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            Console.WriteLine("El caracter ingresado es una vocal.");
                            break;
                        default:
                            Console.WriteLine("El caracter ingresado es una consonante.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El caracter ingresado no es una letra.");
                }
                Console.Write("Desea continuar? (s/n): ");
                linea = Console.ReadLine();
                s = Convert.ToChar(linea);
                v = char.ToLower(s);
            } while (v == 's');
        }
    }
}
