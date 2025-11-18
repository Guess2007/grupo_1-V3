using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.Write("Nombre del solicitante: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingreso mensual: ");
            double ingresomensual = double.Parse(Console.ReadLine());

            Console.Write("Antigüedad laboral: ");
            int antiguedadlaboral = int.Parse(Console.ReadLine());


            string resultado = "";

            if (edad >= 21 && ingresomensual >= 2000)
            {

                if (antiguedadlaboral > 2)
                {
                    resultado = "Aprobado";
                }
                else
                {
                    resultado = "Aprobado con observación";
                }
            }
            else
            {

                resultado = "Rechazado";
            }


            Console.WriteLine("--- Resultado de la Evaluación ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Resultado: " + resultado);

        }
    }
}
