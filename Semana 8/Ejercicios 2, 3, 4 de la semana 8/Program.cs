using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_la_semana_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculos calcularfactorial = new calculos();
            calcularfactorial.calcularfactorial();
            calculos calcularpotencia = new calculos();
            calcularpotencia.calcularpotencia();
            calculos compararnumeros = new calculos();
            compararnumeros.compararnumeros();
        }
    }
}
