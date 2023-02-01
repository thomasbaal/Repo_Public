using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Private_set_Constructors_Example_from_school
{
    internal class Person
    {

        public string Name { get; private set; } // property
        public string Address { get; private set; }
        public string Test { get; set; }


        public Person(string name) // her tar vi  inn hvilke startverdi vi vil personen skal ha constructoren     
        {
            Name = name; // da kan person klassen endre verdien på propertyen Name til den gitte verdien.
        }

        public Person(string name, string test) // her tar vi  inn hvilke startverdi vi vil personen skal ha constructoren     
        {
            Name = name; // da kan person klassen endre verdien på propertyen Name til den gitte verdien.
            Test = test;
        }


        // To be able to change a value that is set to private "Address", make a method inside the class.
        // properties on "Address" are by default set to private.
        public void UpdateAddress(string updateAddress)
        {
            Address = updateAddress;    // passing in new values and change "Address", while keeping it more secure
        }

    }
}
