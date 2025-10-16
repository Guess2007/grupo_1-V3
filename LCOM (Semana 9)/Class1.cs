sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BIBLIOTECAABC
{
    public class FUNCIONES
    {
        public static int sumar(int x, int y) 
        {
            return x + y;
        }
        public static int restar(int x, int y)
        {
            return x - y;
        }
        public static int dividir(int x, int y)
        {
            return x / y;
        }
        public static int multiplicar(int x, int y)
        {
            return x * y;
        }
        public static void mostrarArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
