using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning_objekter_via_static_02
{
    class Place
    {
        // Class Variables !!--
        // everything static is connected to the class !!!---

        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public string Address { get; private set; }
        public int Postnumber { get; private set; }

        public Place(string fName, string lname, string address, int postnumber)
        {
            Fname = fName;
            Lname = lname;
            Address = address;
            Postnumber = postnumber;
        }




        //Place.ShowPlace("Thomas", "Blæsrøden", "Kvelde", 3282);
        public void ShowPlace(string fName, string lName, string address, int postNumber)
        {
            var padLeft = 2;
            
            ShowSeperator(8);
            ShowInfo(padLeft, 10, 43, fName, lName, address, postNumber);
            ShowSeperator();

        }


        private void ShowInfo(int padLeft, int padLeft_2, int age, string firstName, string lastName, string address, int postNumber)
        {
            //padLeft_2 -= firstName.Length;
            WriteLine($"{string.Empty.PadLeft(padLeft, ' ')}Firstname: {string.Empty.PadLeft(padLeft_2, ' ')}{firstName}");
            WriteLine($"{string.Empty.PadLeft(padLeft, ' ')}Lastname: {string.Empty.PadLeft(padLeft_2, ' ')}{lastName}");
            WriteLine($"{string.Empty.PadLeft(padLeft, ' ')}Adress: {string.Empty.PadLeft(padLeft_2, ' ')}{address}");
        }
        private void ShowSeperator()
        {
            WriteLine("*************************");
        }

        private void ShowSeperator(int width)
        {
            width = width * 10;
            WriteLine($"{string.Empty.PadLeft(width, '*')}");
        }

    }
}
