using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Deleteme_Inheritance
{
    internal class Person
    {
        public string  Name { get; set; }

        public void DisplayName()
        {
            WriteLine("My name is {0}", Name);

        
        }

    }
   

}
