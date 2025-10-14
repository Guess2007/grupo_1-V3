using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_9
{
    internal class profesor
    {
        static public void enviarMensajeProfesor() 
        {
            Console.WriteLine("enviando mensaje al alumno");
            Console.WriteLine("Fecha de envio: "); utilitaria.obtenerfecha();  
        }
    }
}
