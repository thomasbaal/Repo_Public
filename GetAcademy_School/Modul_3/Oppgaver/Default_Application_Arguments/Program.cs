using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Application_Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var argument in args)
            {
            Console.WriteLine(argument);
                Console.ReadLine();

            }
        }
    }
}
