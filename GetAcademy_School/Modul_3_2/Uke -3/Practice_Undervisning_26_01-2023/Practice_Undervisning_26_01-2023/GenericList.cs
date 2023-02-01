using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Undervisning_26_01_2023
{
    internal class GenericList<T>
    {
        //private string[] _numbers;
        //private char[] _chars;
        private T[] _values;
        private int _count;
        //private int _countInts;
        //private int _countChars;

        public GenericList(int startCapacity = 4)
        {
            //_numbers = new T[startCapacity];
            //_chars = new T[startCapacity];
            _values = new T[startCapacity]; 
            _count = 0;
        }

        public void Add(T value)
        {
            var index = _count;
            if (index >= _values.Length)
            {
               Resize();
            }

            _values[index] = value;
            _count++;
        }

        public void Resize()
        {
            var newTArray = new T[_values.Length * 2];
            Array.Copy(_values, newTArray, _values.Length);
            _values = newTArray;
        }

        public void Show()
        {
            Console.WriteLine();
            foreach (var symbols in _values)
            {
                Console.Write(symbols + " ,");
            }
            Console.WriteLine();
        }
     
    }
}
