using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string cliente = Console.ReadLine();
            Console.Write("Ingrese el monto total de la compra: S/");
            double montog = double.Parse(Console.ReadLine());
            double desc = 0;
            double porcentajed = 0;
            if (montog >= 1000)
            {
                porcentajed = 0.10;
                desc = montog * porcentajed;
            }
            else if (montog >= 500 && montog < 1000)
            {
                porcentajed = 0.05;
                desc = montog * porcentajed;
            }
            double totalp = montog - desc;
            Console.WriteLine("Resumen de la compra");
            Console.WriteLine($"Nombre del cliente: {cliente}");
            Console.WriteLine("Monto original:S/" {montog:F2}");
            Console.WriteLine($"Porcentaje de descuento aplicado:S/ {porcentajed * 100}%");
            Console.WriteLine($"Descuento aplicado:S/ ${desc:F2}");
            Console.WriteLine($"Total a pagar:S/ ${totalp:F2}");
        }
    }
}   
