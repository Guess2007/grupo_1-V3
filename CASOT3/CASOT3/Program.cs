using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CASOT3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int limit = 100, ind;
            string producto;
            string[] nombres = new string[limit];

            int opciones = 0;

            Console.WriteLine("MENU PRINCIPIAL");
            Console.WriteLine("1.Salir");
            Console.WriteLine("2.Registro de productos");
            Console.WriteLine("3.Mostrar lista de productos");
            Console.WriteLine("4.Buscar producto");
            Console.WriteLine("5.Modificar producto");
            Console.WriteLine("6.Insertar producto");
            Console.WriteLine("7.Eliminar producto");

            while (opciones != 1)
            {

                Console.WriteLine("Por favor eliga una opcion: ");
                opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {

                    case 2:
                        Console.WriteLine("¿Cuantos productos desea registrar? (Max. 100)");
                        limit = int.Parse(Console.ReadLine());

                        for (int j = 1; j <= limit; j++)
                        {
                            Console.WriteLine("Producto numero " + j);
                            nombres[j] = Console.ReadLine();
                        }

                        break;

                    case 3:
                        Console.WriteLine("LISTA DE PRODUCTOS");

                        for (int i = 1; i <=limit; i++)
                        {
                            Console.WriteLine("[{0}]", nombres[i]);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Indique nombre de producto a buscar");


                        break;

                    case 5:
                        Console.Write("Ingrese posición de producto a modificar");
                        ind = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nombre del producto a ingresar");
                        nombres[ind] = Console.ReadLine();



                        break;

                    case 6:
                        Console.WriteLine("Ingrese producto a insertar");
                        
                        break;
                    case 7:

                        break;
                }


            }
            

        }
    }
}
