using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Code_Along
{
    internal class Kodelås
    {
        private int _number;
        public int AntallSiffer;

        public Kodelås(int number, int antallSiffer)
        {
            _number = number;
            AntallSiffer = antallSiffer;
        }

        public void Run()
        {
            WriteLine("Type in a number for the lock !");
            try
            {
                var userInput = Convert.ToInt32(ReadLine());
                if (userInput == _number)
                {
                    WriteLine("Woopi dude !");
                }
                else
                {
                    WriteLine("Burp, wrong !!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
