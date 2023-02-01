using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    class Rectangle02
    {
        private float _area;
        private float _width;
        // Todo: create a property height that can be read from outside.
        public float Height => _area / _width;

        private Rectangle02(float width, float height)
        {
            _area = _width * height;
            _width = width;
        }

        public float Area()
        {
            return _area;
        }

        
        
    }
}
