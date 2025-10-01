using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_semana_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string linea;
            char consonante, vocal, cifra;

            Console.WriteLine("Ingrese un caracter: "); linea = Console.ReadLine();
            linea = linea.ToLower();
            consonante = Convert.ToChar(linea);
            vocal = Convert.ToChar(linea);
            cifra = Convert.ToChar(linea);

            if (consonante >= 'b' && consonante <= 'z' && consonante != 'e' && consonante != 'i' && consonante != 'o' && consonante != 'u')
            {
                Console.WriteLine("El caracter ingresado es una consonante");
            }
            else if (vocal == 'a' || vocal == 'e' || vocal == 'i' || vocal == 'o' || vocal == 'u')
            {
                Console.WriteLine("El caracter ingresado es una vocal");
            }
            else if (cifra >= '0' && cifra <= '9')
            {
                Console.WriteLine("El caracter ingresado es una cifra");
            }
            else
            {
                Console.WriteLine("El caracter ingresado no es una letra ni una cifra");
                return;
            }

        

        }
    }
}
