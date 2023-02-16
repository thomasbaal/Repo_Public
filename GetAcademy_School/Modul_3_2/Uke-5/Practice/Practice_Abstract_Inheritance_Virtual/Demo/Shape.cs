using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Shape
    {

        private string _name { get; }
        private string _color { get; }


        protected Shape(string name, string color)
        {
            _name = name;
            _color = color;
        }
        public abstract double CalculateArea();

        public virtual string GetInfo()
        {
            return $"Name :{_name}\nColor :{_color}\n";
        }

    }
}
