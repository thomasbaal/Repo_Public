using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_Overloads_og_default_value
{
    internal class Person
    {
        public string Name  { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name)
        {
                Name = name;
        }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public Person(string name, int age, string address)
        {
            Name = name;
            Age=age;
            Address = address;
        }

        public void PrintInfo(string extraInfo = " er ikke fullt så tøff") // extraInfo Set to default values if no arguments is passed in.
        {
            Console.WriteLine(Name + " " + extraInfo);
        }


       
    }
}
