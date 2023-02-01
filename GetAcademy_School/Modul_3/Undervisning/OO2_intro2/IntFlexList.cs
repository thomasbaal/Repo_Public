using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OO2_intro2
{
    internal class IntFlexList
    {
        private int[] _numbers = new int[4];
        private int _count = 0;

        public void AddName(int number)
        {
            if (_count >= _numbers.Length)
            {
                //Array.Resize(ref _numbers, _numbers.Length*2); -> showing you what this really does.
                var newNumbers = new int[_numbers.Length * 2]; // it creates a new array with double the size as teh first array.
                Array.Copy(_numbers, newNumbers, _numbers.Length); // copy the values from old array to new array,defining size of the first array.
                _numbers = newNumbers; // new_numbers are then refering to the _numbers array.
                WriteLine($"Doubling the capacity from {_numbers.Length} to {newNumbers.Length}");
                _numbers = newNumbers;
            }
            _numbers[_count] = number;
            _count++;
        }

        //public int GetValues()
        //{
        //return string.Join(", ", _numbers);
        //}

    }
}