using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Krokodille_Spillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                For hver runde skal det printes ut til skjermen et random tall mellom 1-11, et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5

                Brukeren kan skrive inn <, > eller =

                i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5
            */

            
            // Testing out the random class.
            //Random random = new Random(1); // the "1" is called a seed number, you wil then generate the same random numbers every time.
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(5, 12)); // "alsmost random" The "Next" is important as it calls the next set of random numbers. "5" = start integer, "12" = end integer(up to 11, not including 12)

            }

            Console.ReadLine();
            Console.WriteLine("Now to the Method !");
            SimpleMethod(random);
            Console.ReadLine();
            Console.WriteLine("Now to the Method With Double * 10 !");
            SimpleMethod2(random);
            Console.ReadLine();
            Console.WriteLine("Now to the Method With Next but using * 10 !");
            SimpleMethod3(random);
            Console.ReadLine();
        }




        public static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next(5, 10));
            Console.ReadLine();
        }

        public static void SimpleMethod2(Random random)
        {
            Console.WriteLine(random.NextDouble() * 10);

        }

        public static void SimpleMethod3(Random random)
        {
            Console.WriteLine(random.Next(100) * 10); // example 870 0 -> 100 * 10 (87 * 10)
        }

        


    }
}
