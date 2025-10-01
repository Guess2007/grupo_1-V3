using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int producto, num1, num2, num3;
            string linea;

            Console.WriteLine("bienvenido, ingrese su pedido"); linea = Console.ReadLine();
            producto = int.Parse(linea);

            if (producto == 1)
            {
                Console.WriteLine("usted ha elegido comida, seleccione el producto que desea"); linea = Console.ReadLine();
                producto = int.Parse(linea);
                switch (producto)
                {
                    case 1:
                        Console.WriteLine("usted ha elegido PAN \n precio: 3.50");
                        Console.WriteLine("¿Desea continuar con su compra? s/n"); linea = Console.ReadLine();
                        
                        if (linea == "s")
                        {
                            Console.WriteLine("compra realizada exitosamente, tenga buen dia");
                            Console.ReadKey();
                        }
                        else if (linea == "n")
                        {
                            Console.WriteLine("compra cancelada...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("comando invalido-");
                        }
                        break;
                        case 2:
                        Console.WriteLine("usted ha elegido tallarines verdes \n precio: 5.00");
                        Console.WriteLine("¿Desea continuar con su compra? s/n"); linea = Console.ReadLine();
                        
                        if (linea == "s")
                        {
                            Console.WriteLine("compra realizada exitosamente, tenga buen dia");
                            Console.ReadKey();
                        }
                        else if (linea == "n")
                        {
                            Console.WriteLine("compra cancelada...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("comando invalido-");
                        }
                        break;
                        case 3:
                        Console.WriteLine("usted ha elegido aji de gallina \n precio: 4.50");
                        Console.WriteLine("¿Desea continuar con su compra? s/n"); linea = Console.ReadLine();
                        
                        if (linea == "s")
                        {
                            Console.WriteLine("compra realizada exitosamente, tenga buen dia");
                            Console.ReadKey();
                        }
                        else if (linea == "n")
                        {
                            Console.WriteLine("compra cancelada...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("comando invalido-");
                        }
                        break;
                    default:
                        Console.WriteLine("comando invalido");
                        break;
                }
            }
            else if (producto == 2)
            {
                Console.WriteLine("usted ha elegido bebida, seleccione el producto que desea"); linea = Console.ReadLine();
                producto = int.Parse(linea);
                switch (producto)
                {
                    case 1:
                        Console.WriteLine("usted ha elegido CHICHA \n precio: 2.50");
                        Console.WriteLine("¿Desea continuar con su compra? s/n"); linea = Console.ReadLine();
                        
                        if (linea == "s")
                        {
                            Console.WriteLine("compra realizada exitosamente, tenga buen dia");
                            Console.ReadKey();
                        }
                        else if (linea == "n")
                        {
                            Console.WriteLine("compra cancelada...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("comando invalido-");
                        }
                        break;
                    case 2:
                        Console.WriteLine("usted ha elegido INCA COLA \n precio: 6.00");
                        Console.WriteLine("¿Desea continuar con su compra? s/n"); linea = Console.ReadLine();
                        
                        if (linea == "s")
                        {
                            Console.WriteLine("compra realizada exitosamente, tenga buen dia");
                            Console.ReadKey();
                        }
                        else if (linea == "n")
                        {
                            Console.WriteLine("compra cancelada...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("comando invalido-");
                        }
                        break;
                    case 3:
                        Console.WriteLine("usted ha elegido PEPSI \n precio: 2.50");
                        Console.WriteLine("¿Desea continuar con su compra? s/n"); linea = Console.ReadLine();
                        
                        if (linea == "s")
                        {
                            Console.WriteLine("compra realizada exitosamente, tenga buen dia");
                            Console.ReadKey();
                        }
                        else if (linea == "n")
                        {
                            Console.WriteLine("compra cancelada...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("comando invalido-");
                        }
                        break;
                    default:
                        Console.WriteLine("comando invalido");
                        break;
                }
            }
            else
            {
                Console.WriteLine("comando invalido, intente de nuevo");
            }
                
        }
    }
}
