using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double descuento;

            //netrada de datos
            Console.WriteLine("ingrese el consumo del cliente: ");
            double consumo=Convert.ToDouble(Console.ReadLine());


            //proceso: calculo del descuento segun promedio
            if (consumo <= 100)
            {
                descuento = consumo * 0.1;
            }
            
            else if (consumo > 100 && consumo <= 200)
            {
                descuento = consumo * 0.2;
            }
            
            else
            {
                descuento = consumo = 0.3;
            }

            //caluclo deñ monto final


            double subtotal = consumo - descuento;
            double impuesto = subtotal * 0.18;
            double totalpagar = subtotal + impuesto;
            Console.WriteLine("-------Total del consumo--------");
            Console.WriteLine("el consumo del cliente es:S/ " + consumo);
            Console.WriteLine("el descuento aplicado es:S/ " + descuento);
            Console.WriteLine("el impuesto a pagar es:S/ " + impuesto);
            Console.WriteLine("monto final a pagar es:S/ " + totalpagar);







        }
    }
}
