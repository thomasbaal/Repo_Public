using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Passord_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                WriteLine("Hei " + arg);   
            }

            ReadLine();
        }
    }
}
