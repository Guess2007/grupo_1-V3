using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4__Semana_9_
{
    internal class algoritmo
    {
        static public void choose() 
        {
            Console.WriteLine("¿Planea quedarse en casa o salir?"); string linea; linea = Console.ReadLine();
            if (linea == "casa") 
            {
                hora();
            }
            else if (linea == "salir") 
            {
                hora();
            }
            else 
            {
                Console.WriteLine("error:c");
                return;
            }
        }
        static public void hora()
        {
            Console.WriteLine("Registre la hora: ");
            string linea = Console.ReadLine();
            if (linea == "mañana")
            {
                clima();
            }
            else if (linea == "tarde")
            {
                clima();
            }
            else if (linea == "noche")
            {
                clima();
            }
            else 
            {
                Console.WriteLine("dato invalido");
            }
        }
        static public void clima()
        {
            Console.WriteLine("Registre el clima: ");
            string linea; linea = Console.ReadLine();

            if (linea == "nublado")
            { 
                Console.WriteLine("Clima registrado: " + linea);
                Console.WriteLine("Estas son las actividades que podria realizar: \n 1. Leer en casa con un te\n 2.Dormir \n 3.Ejercicio en casa\n 4. Ver tv");
            }
            else if (linea == "despejado") 
            {
                Console.WriteLine("Clima registrado: " + linea);
                Console.WriteLine("Estas son las actividades que podria realizar: \n 1. Ir a un supermercado\n 2. Ir al parque \n 3. Camianr por las calles\n 4. Ir al monte");
            }
            else if(linea == "lluvioso") 
            {
                Console.WriteLine("Clima registrado: " + linea);
                Console.WriteLine("Estas son las actividades que podria realizar: \n 1. Leer en casa\n 2.Dormir \n 3.Ejercicio en casa\n 4. Ver tv");
            }
            else
            {
                Console.WriteLine("Dato invalido...");
            }
        }
    }
}
