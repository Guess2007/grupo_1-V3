using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class ValidadorDatos
    {
        public static bool MayorEdad (int numero)
        {
            if (numero >= 18) 
            {
                return true;
            }
            else 
            {
               return false;
            }
        } 
        public static bool Valido(out int numero,string dato)
        {
            return int.TryParse(dato, out numero);
        }
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            bool valido1;
            int num ;
            string Line;
            do 
            {
                Console.Write("escribe tu edad  :");
                Line = Console.ReadLine(); valido1 = ValidadorDatos.Valido( out num, Line);

                if (!valido1)
                {
                    Console.WriteLine("*INGRESAR UN DATO VALIDO*");
                }

            } while (!valido1);
            
            if (ValidadorDatos.MayorEdad(num))
            {
                Console.WriteLine("Mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }
        }
    }
}
