using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static List<char> listaDecimalHexagecimal(int n)
        {
            List<char> hexChars = new List<char>();

            if (n == 0)
            {
                hexChars.Add('0');
                return hexChars;
            }
            while (n > 0)
            {  
                int remainder = n % 16;
                char hexChar;

                if (remainder < 10)
                {  
                    hexChar = (char)(remainder + '0');
                }
                else
                {  
                    hexChar = (char)(remainder + 'A' - 10);
                }

                hexChars.Add(hexChar);

                n = n / 16;
            }

            hexChars.Reverse();

            return hexChars;
        }
        static List<int> listaDecimalBinario(int n)
        {
            List<int> Bits = new List<int>();

            if (n == 0)
            {
                Bits.Add(0);
                return Bits;
            }

            while (n > 0)
            {
                int remainder = n % 2;
                Bits.Add(remainder);
                n = n / 2;
            }
            Bits.Reverse();

            return Bits;
        }
        static void Main(string[] args)
        {
            int Numero;

            Console.Write("Ingrese un número decimal: ");
            string linea = Console.ReadLine(); 
            if (!int.TryParse(linea , out Numero))
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero.");
                return;
            }

            List<int> binaryArray = listaDecimalBinario(Numero);

            Console.Write($"El número binario de {Numero} es: ");

            foreach (int bit in binaryArray)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            
            List<char> hexArray = listaDecimalHexagecimal(Numero);

            Console.Write($"El número hexadecimal de {Numero} es: ");
            
            foreach (char hexChar in hexArray)
            {
                Console.Write(hexChar);
            }

            Console.WriteLine();
        }
    }
}
