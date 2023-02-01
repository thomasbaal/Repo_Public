using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var q1 = "Hvor bor du ?";
            var q2 = "Hva heter du";

            var q1Answer = SecondClass.Ask(q1);

            Console.WriteLine(q1Answer);
            Console.ReadLine();




        }
    }
}
