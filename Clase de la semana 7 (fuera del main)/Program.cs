using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_de_la_semana_7__fuera_del_main_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dat1 = 0;
            double dat2 = 0;

            Console.WriteLine("Ingrese la base y la altura del rectangulo: ");
            Console.Write("INGRESE LA BASE: ");
            dat1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("INGRESE LA ALTURA: ");
            dat2 = Convert.ToDouble(Console.ReadLine());

            Rectangulo rectangulo = new Rectangulo(dat1, dat2);
            rectangulo.calcularArea();
            double perimetro = rectangulo.calcularPerimetro();

            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
            double area = rectangulo.calcularArea2(3, 6);
            Console.WriteLine("El area 2 del rectangulo es: " + area);
        }
    }
}
