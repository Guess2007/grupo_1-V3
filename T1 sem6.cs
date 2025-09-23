using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 0, B = 0, C = 0, D = 0;
            double num = 0;
            string entrada1;
            string entrada2;
            string entrada3;

            bool valid = true;
            bool valid2;
            do
            {
               
                Console.WriteLine("¿Que menu desea?\n- Comida  (A)\n- Bebidas (B)");
                entrada1 = Console.ReadLine(); entrada2 = entrada1.ToUpper();
                switch (entrada2)
                {
                    case "A":

                        a= 20; B = 10; C = 15; D = 22;
                        do
                        {
                            Console.WriteLine("elija su comida  ");
                            Console.WriteLine("1- pollo saltado     : s/20.00");
                            Console.WriteLine("2- arroz chaufa      : s/10.00");
                            Console.WriteLine("3- tallarines verdes : s/15.00");
                            Console.WriteLine("4- aji de gallina    : s/22.00");
                            
                            entrada3 = Console.ReadLine();
                            valid2 = double.TryParse(entrada3,out num);
                            if (!valid)
                            {
                                Console.WriteLine("Opcion no registrada, intente denuevo ");
                            }
                            if (num == 0)
                            {
                                Console.WriteLine("Opcion no registrada, intente denuevo ");
                                valid2 = false;
                            }
                            if (num > 5 )
                            {
                                Console.WriteLine("Opcion no registrada, intente denuevo ");
                                valid2 = false;
                            }

                        } while (!valid2);
                        switch (num)
                        {
                            case 1:
                               
                                if (a > 20 )
                                {
                                    a = a - ((a * 10) / 100);
                                } 
                                Console.WriteLine(" monto a pagar = s/"+a);
                                break;
                            case 2:
                                
                                if (B > 20)
                                {
                                    B = B - ((B * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/"+ B);
                                break;
                            case 3:
                                
                                if (C > 20)
                                {
                                    C = C - ((C * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/"+ C);
                                break;  
                            case 4:
                                
                                if (D > 20)
                                {
                                    D = D - ((D * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/"+ D);
                                break;  

                        }

                      
                        break;
                    case "B":
                        a = 15; B = 8; C = 12; D = 17;
                        do
                        {
                            Console.WriteLine("elija su bebida ");
                            Console.WriteLine("1-  cafe pasado       : s/15.00");
                            Console.WriteLine("2-  te de jinseg      : s/08.00");
                            Console.WriteLine("3-  mate de palo      : s/12.00");
                            Console.WriteLine("4-  te de burbujas    : s/17.00");

                            entrada3 = Console.ReadLine();
                            valid2 = double.TryParse(entrada3, out num);
                            if (!valid)
                            {
                                Console.WriteLine("Opcion no registrada, intente denuevo ");
                            }
                            if (num == 0)
                            {
                                Console.WriteLine("Opcion no registrada, intente denuevo ");
                                valid2 = false;
                            }
                            if (num > 5)
                            {
                                Console.WriteLine("Opcion no registrada, intente denuevo ");
                                valid2 = false;
                            }

                        } while (!valid2);
                        switch (num)
                        {
                            case 1:
                                
                                if (a > 20)
                                {
                                    a = a - ((a * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/" + a);
                                break;
                            case 2:
                                
                                if (B > 20)
                                {
                                    B = B - ((B * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/" + B);
                                break;
                            case 3:
                                
                                if (C > 20)
                                {
                                    C = C - ((C * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/" + C);
                                break;
                            case 4:
                                
                                if (D > 20)
                                {
                                    D = D - ((D * 10) / 100);
                                }
                                Console.WriteLine(" monto a pagar = s/" + D);
                                break;

                        }
                        
                        
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDA\n (Por favor , ingrese solo A o B )");
                        valid = false;
                        break;

                }

            } while (!valid);


        }
               
    }
}
