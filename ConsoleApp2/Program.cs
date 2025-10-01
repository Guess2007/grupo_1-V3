using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio1 = 4.90, precio2 = 5.30, precio3 = 4.90;
            double precio4 = 4.10, precio5 = 5.30, precio6 = 3.70;
            double precio7 = 3.30, precio8 = 4.90, precio9 = 4.90, precio10 = 5.30;
            string linea = "";
            double producto2 = 0;
            string producto;
            string producto1;
            double a = 0;
            producto1 = "";
            Console.WriteLine("ingrese la categoria del producto\n-salados\n-dulces\n-bebidas");
            producto = Console.ReadLine(); producto1 = producto.ToUpper();
            if (producto1 == "SALADOS")
            {
                Console.WriteLine("| 1. Patatas fritas (bolsa pequeña)     | S/ 4,90     |");
                Console.WriteLine("| 2. Doritos (bolsa individual)         | S/ 5,30     |");
                Console.WriteLine("| 3. Galletas saladas (Ritz o similar)  | S/ 4,10     |");
                Console.WriteLine("| 4. Cacahuetes salados (snack)         | S/ 4,50     |");
                Console.WriteLine("| 5. Palomitas de maíz (bolsa pequeña)  | S/ 5,30     |");
                Console.WriteLine("| 6. Mix de frutos secos (25-30g)       | S/ 6,20     |");
                Console.WriteLine("| 7. Mini pretzels                      | S/ 4,50     |");
                Console.WriteLine("| 8. Nachos con salsa (pack individual) | S/ 7,40     |");
                Console.WriteLine("| 9. Bastoncillos de pan con queso      | S/ 4,90     |");
                Console.WriteLine("| 10. Chips de vegetales                | S/ 6,20     |");
                Console.Write("ingresa el numero de el producto que deseas: ");

                string entrada1 = Console.ReadLine(); a = double.Parse(entrada1);
                switch (a)
                {
                    case 1:
                        Console.WriteLine("monto a pagar : S/ 4.90");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 2:
                        Console.WriteLine("monto a pagar : S/ 5.30");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 3:
                        Console.WriteLine("monto a pagar : S/ 4.10");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 4:
                        Console.WriteLine("monto a pagar : S/ 4.50");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 5:
                        Console.WriteLine("monto a pagar : S/ 5.30");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 6:
                        Console.WriteLine("monto a pagar : S/ 6.20");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 7:
                        Console.WriteLine("monto a pagar : S/ 4.50");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 8:
                        Console.WriteLine("monto a pagar : S/ 7.40");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 9:
                        Console.WriteLine("monto a pagar : S/ 4.90");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 10:
                        Console.WriteLine("monto a pagar : S/ 6.20");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    default:
                        Console.WriteLine("opcion seleccionada no valida");
                        break;
                }
            }
            else if (producto1 == "DULCES")
            {
                Console.WriteLine("| 1. KitKat                          | S/ 4,90     |");
                Console.WriteLine("| 2. M&M’s (bolsa pequeña)           | S/ 5,30     |");
                Console.WriteLine("| 3. Snickers                        | S/ 4,90     |");
                Console.WriteLine("| 4. Galletas Oreo (mini paquete)    | S/ 4,10     |");
                Console.WriteLine("| 5. Kinder Bueno                    | S/ 5,30     |");
                Console.WriteLine("| 6. Chicles (Trident o similar)     | S/ 3,70     |");
                Console.WriteLine("| 7. Caramelos / Paletas             | S/ 3,30     |");
                Console.WriteLine("| 8. Twix                            | S/ 4,90     |");
                Console.WriteLine("| 9. Galletas Chips Ahoy (mini)      | S/ 4,90     |");
                Console.WriteLine("| 10. Barrita de granola c/chocolate | S/ 5,30     |");

                Console.WriteLine("¿Que producto desea tomar? ");
                linea = Console.ReadLine();
                producto2 = double.Parse(linea);
                switch (producto2)
                {
                    case 1:
                        Console.WriteLine("Ha seleccionado Kitkat\nEl precio del producto es: " + precio1);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado MandMs\nEl precio del producto es: " + precio2);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccioando Oreos\nEl precio del producto es: " + precio3);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ha seleccionado Kinder\nEl precio del producto es: " + precio4);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ha seleccionado Chicles\nEl precio del producto es: " + precio5);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ha seleccionado Caramlos\nEl precio del producto es: " + precio6);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Ha seleccionado Twix\nEl precio del producto es: " + precio7);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Ha seleccionado Galletas\nEl precio del producto es: " + precio8);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Ha seleccionado Barrita\nEl precio del producto es: " + precio9);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Ha seleccionado Snickers\nEl precio del producto es: " + precio10);
                        Console.ReadKey();
                        Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    default:
                        Console.WriteLine("El producto no existe");
                        Console.ReadKey();
                        break;
                }

            }
            else if (producto1 == "BEBIDAS")
            {
                Console.WriteLine("| 1. CocaCola (330 ml)               | S/ 6,20     |");
                Console.WriteLine("| 2. Agua Mineral (500 ml)           | S/ 4,10     |");
                Console.WriteLine("| 3. Red Bull (250 ml)               | S/ 8,20     |");
                Console.WriteLine("| 4. Nestea (té helado 500 ml)       | S/ 6,20     |");
                Console.WriteLine("| 5. Café frío en lata               | S/ 7,40     |");
                Console.WriteLine("| 6. Aquarius/Gatorade (500 ml)      | S/ 6,60     |");
                Console.WriteLine("| 7. Fanta/Sprite (330 ml)           | S/ 6,20     |");
                Console.WriteLine("| 8. Zumo de naranja (200 ml)        | S/ 4,90     |");
                Console.WriteLine("| 9. Monster Energy (500 ml)         | S/ 9,00     |");
                Console.WriteLine("| 10. Leche con chocolate (200 ml)   | S/ 5,30     |");
                Console.Write("\nIngrese el número de su elección:");

                string entrada = Console.ReadLine();
                int opcion = int.Parse(entrada);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha seleccionado CocaCola (330 ml)\nEl precio es: S/ 6,20");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado Agua Mineral (500 ml)\nEl precio es: S/ 4,10");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccionado Red Bull (250 ml)\nEl precio es: S/ 8,20");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ha seleccionado Nestea (té helado 500 ml)\nEl precio es: S/ 6,20");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ha seleccionado Café frío en lata\nEl precio es: S/ 7,40");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ha seleccionado Aquarius/Gatorade (500 ml)\nEl precio es: S/ 6,60 ");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Ha seleccionado Fanta/Sprite (330 ml)\nEl precio es: S/ 6,20 ");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Ha seleccionado Zumo de naranja (200 ml)\nEl precio es: S/ 4,90 ");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Ha seleccionado Monster Energy (500 ml)\nEl precio es: S/ 9,00");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Ha seleccionado Leche con chocolate (200 ml)\nEl precio es: S/ 5,30 ");
                        Console.Write("¿Desea continuar? s/n: "); linea = Console.ReadLine();
                        if (linea == "n")
                        {
                            Console.WriteLine("Cancelando compra...");
                        }
                        else if (linea == "s")
                        {
                            Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Comando invalido:(");
                        }
                        break;
                    default:
                        Console.WriteLine("Bebida no encontrada,");
                        break;
                }

            }
        }
    }
}
