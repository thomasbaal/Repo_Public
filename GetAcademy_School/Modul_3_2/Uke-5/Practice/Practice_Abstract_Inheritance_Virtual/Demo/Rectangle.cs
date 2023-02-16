using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Rectangle : Shape
    {
        private double _length { get; } = 3;
        private double _width { get; } = 4;

        public Rectangle(double length, double width, string? name, string? color)
        :base(name, color)
        {
            _length = length;
            _width = width;
        }

        public override double CalculateArea()
        {
            return _length * _width;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
