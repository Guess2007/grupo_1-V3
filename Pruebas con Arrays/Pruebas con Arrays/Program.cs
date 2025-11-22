using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_con_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void arrayminus1() 
        { 
            {
                string r;
                char c;
                int ascii;
                Console.Write("Digite un caracter: ");
                c = char.Parse(Console.ReadLine());
                ascii = (int)char.ToUpper(c);
                if (ascii >= 48 && ascii <= 57)
                {
                    r = "es un numero";
                }
                else if (ascii >= 65 && ascii <= 90)
                {
                    r = "es una letra";
                }
                else
                {
                    r = "es una simbolo";
                }
                Console.WriteLine();
                Console.WriteLine("* Resultado: {0}, {1}", c, r);
                Console.ReadKey();
            } 
        }
        public static void array0() 
        { 
            {
                char[] frase;
                int lim, cont_a = 0, cont_e = 0,
                cont_i = 0, cont_o = 0, cont_u = 0;
                Console.Write("Digite una frase: ");
                frase = Console.ReadLine().ToCharArray();
                lim = frase.Length;
                for (int i = 0; i < lim; i++)
                {
                    switch (char.ToUpper(frase[i]))
                    {
                        case 'A':
                            cont_a++;
                            break;
                        case 'E':
                            cont_e++;
                            break;
                        case 'I':
                            cont_i++;
                            break;
                        case 'O':
                            cont_o++;
                            break;
                        case 'U':
                            cont_u++;
                            break;
                    }
                }
                Console.WriteLine("\nContador de vocales.");
                Console.WriteLine("* Vocal a: {0}", cont_a);
                Console.WriteLine("* Vocal e: {0}", cont_e);
                Console.WriteLine("* Vocal i: {0}", cont_i);
                Console.WriteLine("* Vocal o: {0}", cont_o);
                Console.WriteLine("* Vocal u: {0}", cont_u);
                Console.ReadKey();
            } 
        }
        public static void array1() 
        { 
            {
                int lim1, lim2;
                char[] s = "Bienvenido ".ToCharArray();
                char[] n;
                Console.Write("* Ingresar su normbre: ");
                n = Console.ReadLine().ToCharArray();
                lim1 = s.Length;
                lim2 = n.Length;
                Array.Resize(ref s, lim2 + lim1);
                for (int i = 0; i < lim2; i++)
                {
                    s[lim1 + i] = n[i];
                }
                lim1 = lim1 + lim2;
                Console.WriteLine();
                Console.Write("* Frase: ");
                for (int i = 0; i < lim1; i++)
                {
                    Console.Write("{0}", s[i]);
                }
                Console.ReadKey();
            } 
        }
        public static void array2() 
        { 
            {
                string[] paises = { "peru", "Brasil", "Colombia", "Argentina", "Bolivia" };
                string a;

                foreach (var pais in paises)
                {
                    Console.WriteLine("Pais numero: " + pais);
                }
                Console.WriteLine("****************************************************");

                List<string> list = new List<string>() { "peru", "Brasil", "Colombia", "Argentina", "Bolivia" };

                Console.WriteLine("Ingrese el elemento a eliminar: ");
                a = Console.ReadLine();

                list.Remove(a);
                foreach (var pais in list)
                {
                    Console.WriteLine("Pais: " + pais);
                    Console.ReadKey();
                    Console.WriteLine("Presione enter para finalizar...");
                    Console.ReadKey();
                }
            } 
        }
        public static void array3() 
        { 
            {

            } 
        }
    }
}
