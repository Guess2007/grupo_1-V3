using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_grupal_semana_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c_producto1, c_producto2;
            double discount;
            double subtotal, total;
            double producto1, producto2;
            string linea;
            producto1 = 2.20;
            producto2 = 10;
            discount = 15;


            Console.WriteLine("registre cantidad de productos: "); linea = Console.ReadLine();
            c_producto1 = double.Parse(linea);
            Console.WriteLine("registre cantidad de productos: "); linea = Console.ReadLine();
            c_producto2 = double.Parse(linea);

            subtotal = (producto1 * c_producto1) + (producto2 * c_producto2);
            if (subtotal >= 100)
            {
                total = subtotal - (subtotal * discount / 100);
                Console.WriteLine("el total a pagar es: " + total);
            }
            else
            {
                total = subtotal;
                Console.WriteLine("el total a pagar es: " + total);
            }

            Console.WriteLine("¿Desea continuar con su compra? (s/n)");
            linea = Console.ReadLine();

            if (linea == "s")
            {
                Console.WriteLine("Gracias por su compra");
            }
            else
            {
                Console.WriteLine("Compra cancelada");
            }
            Console.ReadKey();
        }
    }
}
