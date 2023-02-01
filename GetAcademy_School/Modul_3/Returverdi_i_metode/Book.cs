using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returverdi_i_metode
{
    public class Book
    {
        public string Name { get; private set; }
        private string _name2;

        public Book(string name)
        {
            Name = name;
            _name2 = "thomas";
        }

        public string getName2()
        {
            return _name2;
        }
    }
}

// internal, private, public, protected.
