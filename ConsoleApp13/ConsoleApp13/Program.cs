using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombreCliente;
            int tipoCliente;
            double montoCompra;
            double descuento = 0;
            string tipoClienteStr = "";

            Console.WriteLine("--- Cálculo de Descuento en Tienda ---");
            Console.Write("Ingrese el nombre del cliente: ");
            nombreCliente = Console.ReadLine();

            Console.Write("Ingrese el tipo de cliente (1. Regular, 2. VIP, 3. Mayorista): ");
            tipoCliente = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el monto de la compra: ");
            montoCompra = double.Parse(Console.ReadLine());

            switch (tipoCliente)
            {
                case 1:
                    tipoClienteStr = "Regular";

                    if (montoCompra > 500)
                    {
                        descuento = montoCompra * 0.05;
                    }
                    break;
                case 2:
                    tipoClienteStr = "VIP";

                    {
                        descuento = montoCompra * 0.10;
                    }
                    break;
                case 3:
                    tipoClienteStr = "Mayorista";
                    if (montoCompra > 1000)
                    {
                        descuento = montoCompra * 0.15;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo de cliente no válido.");
                    return;
            }

            double montoFinal = montoCompra - descuento;

            Console.WriteLine("\n--- Resumen de la Compra ---");
            Console.WriteLine("Nombre del Cliente: " + nombreCliente);
            Console.WriteLine("Tipo de Cliente: " + tipoClienteStr);
            Console.WriteLine("Monto antes del descuento: $" + montoCompra.ToString("N2"));
            Console.WriteLine("Monto total con descuento: $" + montoFinal.ToString("N2"));


        }
    }
}
