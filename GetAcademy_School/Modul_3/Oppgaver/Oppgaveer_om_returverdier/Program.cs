using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaveer_om_returverdier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summer(12,12));
            Console.ReadLine();
            Console.WriteLine("Push Enter to run next Method");

            MySentence("This is my sentence");
        }

        static int Summer(int a, int b)
        {
            return a + b;
        }

        //Note!. Void betyr at den ikke skal returnere noen verdier.
        // under: bruker void her da den skal bare vise en tekst men ikke returnere noe.
        static void MySentence(string a)
        {
            Console.WriteLine(a);
        }

    }
}
