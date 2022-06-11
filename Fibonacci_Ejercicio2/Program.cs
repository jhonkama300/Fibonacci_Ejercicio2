using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Ejercicio2
{
   public  class Program
    {
        static void Main(string[] args)
        {

            fibonacci(0);
        }

        public static int fibonacci(int numero)
        {

            int PrimerNumero = 0, SegunNumero = 1, SigNumero;



            if (numero == 0)
            {
                return 0;
            }
            else if (numero == 1 || numero == 2)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i <= numero; i++)
                {

                    SigNumero = PrimerNumero;
                    PrimerNumero = SegunNumero;
                    SegunNumero = SigNumero + PrimerNumero;
                }
                Console.WriteLine(PrimerNumero);
                Console.ReadKey();
                return PrimerNumero;


            }

        }
    }

}
