using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OO2_intro2
{

    
    internal class SuperFlexList<T>
    {
        private T[] _values = new T[4]; // Note: T now means it can take several data-types.
        private int _count = 0; 

        public void Add(T value) // passing value as "T" 
        {
            if (_count >= _values.Length)
            {
                //Array.Resize(ref _values, _values.Length*2); -> showing you what this really does.
                var newNumbers = new T[_values.Length * 2]; // it creates a new array with double the size as teh first array.
                Array.Copy(_values, newNumbers, _values.Length); // copy the values from old array to new array,defining size of the first array.
                WriteLine($"Doubling the capacity from {_values.Length} to {newNumbers.Length}");
                _values = newNumbers;
            }
            _values[_count] = value;
            _count++;
        }

        public string GetValues()
        {
            return string.Join(", ", _values);
        }

    }
}