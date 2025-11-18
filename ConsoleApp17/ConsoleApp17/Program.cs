using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        
public class CalculadoraDescuento
        {
            public static void Main(string[] args)
            {                           
                Console.Write("Ingrese el nombre del cliente: ");
                string nombrecliente = Console.ReadLine();
                Console.Write("Ingrese el tipo de cliente (1. Regular, 2. VIP, 3. Mayorista): ");
                int tipoclienteInt = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el monto total de la compra: ");
                double montocompra = double.Parse(Console.ReadLine());

                string tipoliente = "";
                double descuento = 0;               
                switch (tipoclienteInt)
                {
                    case 1:
                        tipoliente = "Regular";
                        
                        if (montocompra > 500)
                        {
                            descuento = montocompra * 0.05;
                        }
                        break;
                    case 2:
                        tipoliente = "VIP";
                      
                        if (montocompra > 300)
                        {
                            descuento = montocompra * 0.10;
                        }
                        break;
                    case 3:
                        tipoliente = "Mayorista";                   
                        if (montocompra > 1000)
                        {
                            descuento = montocompra * 0.15;
                        }
                        break;
                    default:
                        Console.WriteLine("Tipo de cliente no válido.");
                        return; 
                }
                double montofinal = montocompra - descuento;        
                Console.WriteLine("--- Resumen de la compra ---");
                Console.WriteLine("Cliente: {nombrecliente}");
                Console.WriteLine($"Tipo de cliente: {tipoliente}");
                Console.WriteLine($"Monto total antes del descuento: {montocompra:C}");
                Console.WriteLine($"Monto del descuento: {descuento:C}");
                Console.WriteLine($"Monto total después del descuento: {montofinal:C}");
            }
        }

    }
}

