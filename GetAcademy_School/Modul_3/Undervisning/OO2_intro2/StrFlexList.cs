using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OO2_intro2
{
    internal class StrFlexList
    {
        private string[] _names = new string[4];
        private int _count = 0;

        public void AddName(string name)
        {
            if (_count >= _names.Length)
            {
                //Array.Resize(ref _numbers, _numbers.Length*2); -> showing you what this really does.
                var newNames = new string[_names.Length * 2]; // it creates a new array with double the size as teh first array.
                Array.Copy(_names, newNames, _names.Length); // copy the values from old array to new array,defining size of the first array.
                _names = newNames; // new_numbers are then refering to the _numbers array.
                WriteLine($"Doubling the capacity from {_names.Length} to {newNames.Length}");
                _names = newNames;
            }
            _names[_count] = name;
            _count++;
        }

        public string GetValues()
        {
            return string.Join(", ", _names);
        }

    }
}