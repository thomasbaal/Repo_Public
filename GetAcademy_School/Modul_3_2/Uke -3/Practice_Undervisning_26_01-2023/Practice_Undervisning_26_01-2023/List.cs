using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice_Undervisning_26_01_2023
{
    public class List
    {
        private int[] _numbers;
        private char[] _chars;
        private int _countInts;
        private int _countChars;

        public List()
        {
            _numbers = new int[4];
            _chars = new char[4];   
            _countInts = 0;
        }

        public void AddInts(int number)
        {
            // Resize array in needed:
            if (_countInts > _numbers.Length - 1)
            {
                var newNumbersArray = new int[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbersArray, _numbers.Length);
                _numbers = newNumbersArray;
                Console.WriteLine($"Resized Array to : {_numbers.Length}");
            }
            _numbers[_countInts] = number;
            _countInts++;
        }

        public void PrintInts()
        {
            Console.WriteLine();
            foreach (var number in _numbers)
            {
                Console.Write(number + " ,");
            }
            Console.WriteLine();
        }

        public void PrintChars()
        {
            Console.WriteLine();
            foreach (var character in _chars)
            {
                Console.Write(character + " ,");
            }
            Console.WriteLine();
        }
        public void AddChars(char character)
        {
            // Resize array if needed:
            if (_countChars > _chars.Length - 1)
            {
                var newCharArray = new char[_chars.Length * 2];
                Array.Copy(_chars, newCharArray, _chars.Length);
                _chars = newCharArray;
                Console.WriteLine($"Resized Array to : {_chars.Length}");
            }
            _chars[_countChars] = character;
            _countChars++;
        }
    }
}
