using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Oppgave 1: 

            Lag en metode som tar imot to tall og returnerer true dersom tallene er like.  */

            bool boolean = trueOrFalse(11, 10);
            Console.WriteLine(boolean);
            Console.ReadLine();
        }


        public static bool trueOrFalse(int num1, int num2)
        {
            if(num1 == num2)
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
