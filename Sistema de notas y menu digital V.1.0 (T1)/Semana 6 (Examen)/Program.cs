using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6__Examen_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            int num1, extra, note;
            string linea;
            extra = 20 / 100;
            bool esvalido;

            Console.WriteLine("Ingrese la cantidad de respuestas correctas: "); linea = Console.ReadLine();
            esvalido = int.TryParse(linea, out num1);
            do
            {
                if (!esvalido)
                {
                    Console.WriteLine("El dato ingresado no es valido, intente de nuevo");
                    return;
                }
                else 
                {
                    if (num1 >= 8)
                    {
                        note = num1 + extra;
                        Console.WriteLine("La nota obtenida califica como aprobatoria, felicidades.");
                        Console.WriteLine("Nota calificatoria: " + note);
                        Console.ReadKey();
                    }
                    else if (num1 == 7)
                    {
                        note = num1;
                        Console.WriteLine("Su nota califica como calificatoria:)");
                        Console.WriteLine("Nota calificada: " + note);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Su nota no califica como aprobatoria");
                        Console.WriteLine("Nota calificada: " + num1);
                        Console.ReadKey();
                    }

                }           
            } while (!esvalido);
            */

            string linea;
            bool esvalido;
            int choose, comida, bebida;

            Console.WriteLine("Bienvenido a (Cadenadecomidaquenonospatrocina), ¿Que desea llevar?");
            linea = Console.ReadLine();
            esvalido = int.TryParse(linea, out choose);

            comida = 1;
            bebida = 2;
            do 
            { 
                if (!esvalido) 
                {
                    Console.WriteLine("Comando invalido, intente de nuevo");
                    return;
                }
                else 
                {
                    if (choose == 1)
                    {
                        Console.WriteLine("¿Que comida desea llevar?"); linea = Console.ReadLine();
                        Console.WriteLine("Opcion 1 | precio: (precioreferencial)\n Opcion 2 | precio: (precioreferencial) \n Opcion 3 | precio: (precioreferencial)");
                        switch (comida)
                        {
                            case 1:
                                Console.WriteLine("Usted ha elegido (Menuespecifico), ¿Desea pedir algo mas? s/n? \n Precio = (precioreferente)"); linea = Console.ReadLine();
                                if (linea == "s")
                                {
                                    Console.WriteLine("¿Que desea pedir?");
                                    Console.WriteLine("Opcion 1 \n Opcion 2"); linea = Console.ReadLine();
                                    if (linea == "Opcion 1") 
                                    {
                                        Console.WriteLine("¿Que comida desea agregar?");
                                        Console.WriteLine("Opcion 2 | precio: (precioreferencial) \n Opcion 3 | precio: (precioreferencial)"); linea = Console.ReadLine();
                                        switch (comida) 
                                        {  
                                            case 2:
                                                Console.WriteLine("Usted ha elegido (Menuespecifico), ¿Desea pedir algo mas? s/n? \n Precio = (precioreferente)"); linea = Console.ReadLine();
                                                if (linea == "S") 
                                                {
                                                    Console.WriteLine("¿Que desea pedir?");
                                                    Console.WriteLine("Opcion 1 \n Opcion 2"); linea = Console.ReadLine();
                                                }
                                                break;
                                                case 3:
                                                Console.WriteLine("Usted ha elegido (Menuespecifico), ¿Desea pedir algo mas? s/n? \n Precio = (precioreferente)"); linea = Console.ReadLine();
                                                if (linea == "S")
                                                {
                                                    Console.WriteLine("¿Que desea pedir?");
                                                    Console.WriteLine("Opcion 1 \n Opcion 2"); linea = Console.ReadLine();
                                                }
                                                break;
                                        }
                                    }
                                    else if (linea == "Opcion 2") 
                                    {
                                        Console.WriteLine("¿Que bebida desea pedir?"); linea = Console.ReadLine();

                                    
                                    }
                                }
                                else if (linea == "n")
                                {
                                    Console.WriteLine("¿Desea continuar con su compra?"); linea = Console.ReadLine();
                                    if (linea == "s") 
                                    {
                                        Console.WriteLine("Compra realizada, que tenga buen dia!");
                                        Console.ReadKey();
                                    }
                                    else if (linea == "n") 
                                        {
                                        Console.WriteLine("Compra cancelada...");
                                        Console.WriteLine("D:");
                                        Console.ReadKey();                                   
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Comando invalido, error");
                                        Console.ReadKey();                                    
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("Usted ha elegido (menuespecifico), ¿Desea pedir algo mas");
                                break;
                            case 3:
                                Console.WriteLine("Usted ha elegido (menuespecifico), ¿Desea pedir algo mas");
                                break;
                            default:
                                Console.WriteLine("Opcion invalida, intente de nuevo:D");
                                break;
                        }
                    }
                    else if (choose == 2) 
                    {
                        Console.WriteLine("¿Que bebida desea llevar?"); linea = Console.ReadLine();
                        Console.WriteLine("Opcion 1 \n Opcion 2 \n Opcion 3");
                    }
                    else 
                    {
                        Console.WriteLine("Opcion invalida, intente de nuevo");
                        Console.ReadKey();
                    }       
                }     
            } while (!esvalido);
        }
    }
}
