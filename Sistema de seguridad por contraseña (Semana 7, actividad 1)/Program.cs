using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_seguridad_por_contraseña__Semana_7__actividad_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string linea, Password;

            Console.WriteLine("Bienvenido al sistema de seguridad por contraseña.");
            Console.WriteLine("Por favor, ingrese la contraseña para acceder:"); linea = Console.ReadLine();
            Password = linea;

            if (Password == "Seguridad123")
            {
                Console.WriteLine("Acceso concedido.");
            }
            else if(Password != "Seguridad123")
            {
                Console.WriteLine("Acceso denegado, intente de nuevo.");
                Console.WriteLine("Por favor, ingrese la contraseña para acceder:"); linea = Console.ReadLine();
                Password = linea;
                if (Password == "Seguridad123") 
                {
                    Console.WriteLine("acceso concedido.");
                }
                else if (Password != "Seguridad123")
                { 
                    Console.WriteLine("Acceso denegado, intente de nuevo.");
                    Console.WriteLine("Por favor, ingrese la contraseña para acceder:"); linea = Console.ReadLine();
                    Password = linea;
                    Console.ReadKey();
                    if (Password == "Seguridad123") 
                    {
                        Console.WriteLine("acceso concedido.");
                    }
                    else if (Password != "Seguridad123")
                    { 
                        Console.WriteLine("Acceso denegado, se ha excedido el número de intentos.");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            */

            string linea;
            int num;

            Console.WriteLine("Ingrese un numero:");
            linea = Console.ReadLine();
            num = Convert.ToInt32(linea);

            if (num == 2, 3,  5, 7)
            {
                Console.WriteLine("El numero es primo.");
            }
            else
            {
                Console.WriteLine("El numero no es primo.");
            }
        }
    }
}
