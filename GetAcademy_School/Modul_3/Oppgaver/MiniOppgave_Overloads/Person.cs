using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOppgave_Overloads
{
    internal class Person
    {
        public string Name { get; set; }
        public Person(string name = "Terje")
        {
            Name = name;
        }

        public void PrintInfo(string extraInfo = "Hei og velkommen")
        {
            Console.WriteLine(extraInfo + " " + Name);
        }

    }
}
