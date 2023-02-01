using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_if_else_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Oppgave 2: 

                Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 

                og returnerer tallene multiplisert med hverandre dersom de er like
             */

            int result = Calculate(10, 10);
            Console.WriteLine(result);
            Console.ReadKey();
        }
       
        public static int Calculate(int num1, int num2)
        {
            if(num1 == num2)
            {
                int result;
                result = num1 + num2;
                return result;

            }else 
            {
                int result;
                result = num1 * num2;
                return result;

            }
        }

    }

}
