using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_3__Semana_9_
{
    internal class utilitario
    {
        static public void obtenerfecha(int dato = 1)
        {

            if (dato == 1)
            {
                obtenerfechanow();
            }
            else
            {
                obtenerfechatoday();
            }
        }
        static public void obtenerfechanow()
        {
            Console.WriteLine("La fecha now es: ");
            Console.WriteLine(DateTime.Now.ToString());
        }
        static public void obtenerfechatoday()
        {
            Console.WriteLine("La fecha today es: ");
            Console.WriteLine(DateTime.Today.ToString());
        }
        
    }
}
