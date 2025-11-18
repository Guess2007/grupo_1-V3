using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Semana_14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            opciones();
        }

        public static void array()
        {
            {
                char[] a1 = { 'a', 'b', 'c' };
                char[] a2 = new char[] { 'a', 'b', 'c' };
                char[] a3 = new char[3];

                a3[0] = 'a';
                a3[1] = 'b';
                a3[2] = 'c';

                Console.WriteLine("Tamaño a1[]: " + a1.Length);
                Console.WriteLine("Tamaño a2[]: " + a2.Length);
                Console.WriteLine("Tamaño a3[]: " + a3.Length);
                Console.ReadKey();
            }
        }


        public static void array2()
        {
            {
                char[] l;

                Console.WriteLine("Ingrese mensaje: ");
                l = Console.ReadLine().ToCharArray();

                Console.WriteLine();
                Console.WriteLine("Mnesaje ingreasdo.");
                Console.WriteLine("c[{0}] = ", l.Length);
                for (int i = 0; i < l.Length; i++)
                {
                    Console.WriteLine("[{0}]", l[i]);
                }

                Console.ReadKey();
            }
        }

        public static void array3()
        {
            {
                char[] l;
                Console.WriteLine("* ingresar tu nombre: ");
                l = Console.ReadLine().ToCharArray();

                Console.WriteLine();
                Console.WriteLine("Frase: bienvenido" + l.Length);
            }
        }

        public static void array4()
        {
            {
                int[] numero = { 10, 15, 20, 25 };

                Console.WriteLine(numero.Length);
                for (int i = 0; i < numero.Length; i++)
                {
                    Console.WriteLine(numero[i]);
                }
            }
        }

        public static void array5()
        {
            {
                int lim = 4, ind, num;
                int[] a = new int[lim];

                a[0] = 5;
                a[1] = 10;
                a[2] = 15;
                a[3] = 20;
                Console.WriteLine("array original: " + a.Length);
                Console.WriteLine("");
                Console.WriteLine("a[{0}] = ", lim);
                for (int i = 0; i < lim; i++) 
                {
                    Console.WriteLine("[{0}]", a[i]);
                }
                Console.WriteLine("\n") ;

                Console.WriteLine("*Indice a insertar [0 - 3]: ") ;
                ind = int.Parse(Console.ReadLine());
                Console.WriteLine("*Numero a insertar: ");
                num = int.Parse(Console.ReadLine());

                lim++;
                Array.Resize(ref a, lim);
                for (int i = lim - 1; i > ind; i--) 
                {
                    a[i] = a[i - 1];
                }
                a[ind] = num;

                Console.WriteLine("array nuevo: " + a.Length);
                Console.WriteLine("");
                Console.WriteLine("a[{0}] = ", lim);
                for (int i = 0; i < lim; i++)
                {
                    Console.WriteLine("[{0}]", a[i]);
                }

                
            }

        }

        public static void opciones() 
        { 
            {
                string[] opcion = { "eliminar", "añadir", "salir"};
                string l;
                int n;
                Console.WriteLine("desea realizar alguna otra funcion: "); l = Console.ReadLine();
                Console.WriteLine("opciones: ");
                for (int i = 0; i < opcion.Length; i++)
                {
                    Console.WriteLine(opcion[i]);
                    if (l == opcion[0]) 
                    {
                        Console.WriteLine("*Array a eliminar: ");
                        n = int.Parse(Console.ReadLine());
                        for (int j = 0; j < opcion.Length; j++) { }
                    }
                }
            }
        }
    }
}
