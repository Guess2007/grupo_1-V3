


using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_semana3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            byte lunes, martes, miercoles, jueves, viernes, sabado, domingo;
            string linea;
            bool esvalido;

            Console.WriteLine("INGRESE UN NUMERO: "); linea = Console.ReadLine();
            dia = int.Parse(linea);
            esvalido = int.TryParse(linea, out dia);

            if (dia == 1)
            {
                Console.WriteLine("es lunes");
                lunes = 1;
            }
            if (dia == 2)
            {
                Console.WriteLine("es martes");
                martes = 2;
            }
            if ((dia == 3) || (dia == 4))
            {
                Console.WriteLine("es miercoles");
                Console.WriteLine("es jueves");
                miercoles = 3;
                jueves = 4;
            }
            if (dia == 5)
            {
                Console.WriteLine("es viernes");
                viernes = 5;
            }
            if (((dia == 6) || (dia == 7)))
            {
                Console.WriteLine("es sabado");
                Console.WriteLine("es domingo");
                sabado = 6;
                domingo = 7;
            }
            else if (byte.TryParse(linea, out lunes)) ; byte.TryParse(linea, out martes); byte.TryParse(linea, out miercoles); byte.TryParse(linea, out jueves); byte.TryParse(linea, out viernes); byte.TryParse(linea, out sabado); byte.TryParse(linea, out domingo);)
            {
                Console.WriteLine("dato invalido, cerrando sistema...");

            }

        }
    }
}


