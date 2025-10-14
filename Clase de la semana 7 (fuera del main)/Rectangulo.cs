using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_de_la_semana_7__fuera_del_main_
{
    internal class Rectangulo
    {
        double baseR;
        double alturaR;
        public Rectangulo(double baseR, double alturaR)
        {
            this.baseR = baseR;
            this.alturaR = alturaR;
        }
        public void calcularArea()
        {
            Console.WriteLine("El area del rectangulo es: " + (baseR * alturaR));
        }
        public double calcularPerimetro()
        {
            return 2 * (baseR + alturaR);
        }
        public double calcularArea2(double var1, double var2)
        {
            return var1 * var2;
        }
    }
}
