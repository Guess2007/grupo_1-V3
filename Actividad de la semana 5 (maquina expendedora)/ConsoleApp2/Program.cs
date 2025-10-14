using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int producto;
            string linea;
            bool esvalido;

            Console.WriteLine("Bienvenido"); linea = Console.ReadLine();
            esvalido = int.TryParse(linea, out producto);
            do
            {
                if (!esvalido)
                {
                    Console.WriteLine("Comando invalido, intente de nuevo");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ingrese el tipo de pedido que desea: "); linea = Console.ReadLine();
                    switch (producto)
                    {
                        case 1:
                            Console.WriteLine("Usted ha elegido comida, ¿Que desea llevar? \n opcion 1\n opcion 2\n opcion 3");
                            if (linea == "opcion 1") 
                            {
                                Console.WriteLine("usted ha elegido #####, costo de $3, ¿Desea llevar algo mas? si/no"); linea = Console.ReadLine();
                                if (linea == "si") 
                                {
                                    Console.WriteLine("¿Que desea llevar? \n opcion 2\n opcion 3");
                                    if (linea == "opcion 2")
                                    {
                                        Console.WriteLine("usted ha elegido #####, costo de $4, \n¿Desea llevar algo mas? \nsi/no?"); linea= Console.ReadLine();
                                        if (linea == "opcion 3")
                                        {
                                            Console.WriteLine("usted ha elegido #####, costo de $2, ¿Desea continuar con su compra?\nsi / no ? "); linea = Console.ReadLine();
                                            if (linea == "si")
                                            {
                                                Console.WriteLine("Costo total de: $9");
                                                Console.WriteLine("Pago realizado exitosamente, que tenga buen dia");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                }                          
                            }
                            else if (linea == "opcion 2")
                            {
                                Console.WriteLine("usted ha elegido #####, costo de $4, ¿Desea llevar algo mas? si/no"); linea = Console.ReadLine();
                                if (linea == "si")
                                {
                                    Console.WriteLine("¿Que desea llevar? \n opcion 1\n opcion 3");
                                    if (linea == "opcion 1")
                                    {
                                        Console.WriteLine("usted ha elegido #####, costo de $3, \n¿Desea llevar algo mas? \nsi/no?"); linea = Console.ReadLine();
                                        if (linea == "opcion 3")
                                        {
                                            Console.WriteLine("usted ha elegido #####, costo de $2, ¿Desea continuar con su compra?\nsi / no ? "); linea = Console.ReadLine();
                                            if (linea == "si")
                                            {
                                                Console.WriteLine("Costo total de: $9");
                                                Console.WriteLine("Pago realizado exitosamente, que tenga buen dia");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                }
                                break;
                        case 2:
                            Console.WriteLine("Usted ha elegido bebidas, ¿Que desea llevar? \n opcion 1\n opcion 2\n opcion 3");
                            break;
                    }
            } while (!esvalido);
        }
    }
}
