using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace PasswordGen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 2)
            {
                WriteLine("PasswordGenerator <length> <option>");
                WriteLine(" Options ");
                WriteLine(" - l = lower case letter ");
                WriteLine(" - L = upper case letter ");
                WriteLine(" - d = digit");
                WriteLine(" - s = special character (! \" # % & ¤ / ( ) ");

            }

            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadLine();
        }
    }
}
