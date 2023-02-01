using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_Løkker_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Oppgave 3:

                Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10
             */
            int index = 0;
            int count = 0;  
            while (index < 10)
            {
                index++;
                count++;
                Console.WriteLine("Runde.nummer " + count);
                Console.ReadLine();
            }
        }
    }
}
