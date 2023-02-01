using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_if_else_statements_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Oppgave 3:

                Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
                skal metoden returnere true. Ellers returnerer metoden false
             */

            //Console.WriteLine("First Number !");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("First Number !");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 15;
            int num2 = 15;

            Boolean is30 = Calculate(num1, num2);
            Console.WriteLine(is30);
            Console.ReadLine();


        }

        public static bool Calculate(int num1, int num2)
        {
            if((num1 + num2) == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
