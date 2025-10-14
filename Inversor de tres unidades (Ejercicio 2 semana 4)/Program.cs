using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_semana_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, dec, uni, cen;
            string linea;

            Console.WriteLine("ingrese un numero de tres digitos: "); linea = Console.ReadLine();
            num = int.Parse(linea);

            dec = num / 100;
            cen = (num / 10) % 10;
            uni = num % 10;
            int aux = (uni * 100) + (cen * 10) + dec;

            Console.WriteLine("el numero invertido es: " + aux);
            Console.WriteLine("pulse una tecla: "); Console.ReadLine();


        }
    }
}
