using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_Overloads_og_default_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Thomas");
            var person2 = new Person("Linnea", 43);
            var person3 = new Person("Anders", 35, "tveidarn");

            var animal = new Animal("Dog");


            person1.PrintInfo("er Tøff som fy !");

            person2.PrintInfo();
        }



    }
}
