using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Rectangle
    {
        private float _area;
        private float _width;
        public float Height => _area / _width;

        public Rectangle(float width, float heigth)
        {
            _area = width * heigth;
            _width = width;
        }

        public float Area()
        {
            return _area;
        }






        //private float _width;
        //private float _height;

        //public Rectangle(float width, float height)
        //{
        //    _width = width;
        //    _height = height;
        //}

        //public float Area()
        //{
        //    return _width * _height;
        //}

    }
}
