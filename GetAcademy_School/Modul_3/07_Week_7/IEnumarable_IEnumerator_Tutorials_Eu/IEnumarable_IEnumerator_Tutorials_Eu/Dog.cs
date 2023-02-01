using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IEnumarable_IEnumerator_Tutorials_Eu
{
    internal class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        // method that prints how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            //print a message containng the number of treats and the name of the dog.
            WriteLine("Dog: {0} said wuoff {1} times!", Name, numberOfTreats);
        }
    }
}
