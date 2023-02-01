using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            string[] arrTest = new string[] {"2", "3"};
            Console.WriteLine("------- arrTest start----------");
            Console.WriteLine($"arrTest valid ?: " + IsValid(arrTest)); // False
            
            Console.WriteLine("------- arrTest end----------");
            var options = args[1];

            var pattern = options.PadRight(length, 'l');


            Console.WriteLine(IsValid(args)); // False
            Console.WriteLine(!IsValid(args)); // True

            
        }


    }


}