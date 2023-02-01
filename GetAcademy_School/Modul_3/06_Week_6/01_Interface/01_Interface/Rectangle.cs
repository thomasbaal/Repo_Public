using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _01_Interface
{
    internal class Rectangle : IPolygon, IColor
    {
        public string Name = "R";
        public int Area;
        public static int Index = 0;
        private int _length;
        private int _width;

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
            //Name = ($"{Name}+{Index.ToString()}");
            Name = (Name+Index.ToString());
            Index++;
            CalculateArea(this._length, this._width);
        }
        // need same Methods and name as the class that is using the Interface.
        public void CalculateArea(int l, int b)
        {
            Area = l * b;
            WriteLine("Area of {0} is: {1}", Name, Area);
        }
        public void GetColor()
        {
            WriteLine("{Name} is red");
        }
    }
}
