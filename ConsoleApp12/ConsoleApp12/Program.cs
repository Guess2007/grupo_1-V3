using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cliente;
            int tipo;
            double Montocompra;
            double descuento = 0;
            string tipocliente = "";

            Console.WriteLine("--- Cálculo de Descuento en Tienda ---")
            Console.WriteLine("nombre del cliente: ");
            string clientenombre = Console.ReadLine();
            Console.WriteLine("Tipo de cliente: ");
            int cliente1= int.Parse(cliente);
            Console.WriteLine("Tipo de cliente: ");
            int cliente2 = int.Parse(cliente); 
            Console.WriteLine("Tipo de cliente: ");
            int cliente3 = int.Parse(cliente);


            switch (tipocliente)
            {
                case 1: 
                    if (Montocompra > 500)
                    {
                        descuento = 0.05; 
                        descuento = "Regular";
                    }
                    else
                    {
                        descuento = 0;
                        descuento = "Regular";
                    }
                    break;
                case 2: 
                    if (Montocompra > 300)
                    {
                        descuento = 0.10; 
                        descuento = "VIP";
                    }
                    else
                    {
                        descuento = 0;
                        descuento = "VIP";
                    }
                    break;
                case 3: 
                    if (Montocompra > 1000)
                    {
                        descuento = 0.15; 
                        descuento = "Mayorista";
                    }
                    else
                    {
                        descuento = 0;
                        descuento = "Mayorista";
                    }
                    break;
                default:

                    Console.WriteLine("Tipo de cliente no válido.");
                    return;
            }

                 double montoFinal = Montocompra - descuento;

            
                 Console.WriteLine("--- Resumen de la compra ---");
                 Console.WriteLine($"Cliente: {cliente}");
                 Console.WriteLine($"Tipo de cliente: {tipocliente}");
                 Console.WriteLine($"Monto total antes del descuento: {Montocompra:C}");
                 Console.WriteLine($"Monto del descuento: {descuento:C}");
                 Console.WriteLine($"Monto total después del descuento: {montoFinal:C}");
        }





    }









        }
    }
}
