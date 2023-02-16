using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Circle : Shape
    {

        private double _radius { get; }

        public Circle(double radius, string name, string color) : base(name, color)
        {
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
            
        }
    }
}
