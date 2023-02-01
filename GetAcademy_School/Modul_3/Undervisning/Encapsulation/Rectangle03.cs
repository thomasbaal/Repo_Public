using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Rectangle03
    {
        public float Area { get; set; }
        public float Width { get; set; }

        public float Height
        {
            get => Area / Width;
            set => Area = Width * value;
        }

        public Rectangle03(float width, float height)
        {
            Area = width * height;
            Width = width;
        }

        public void Whatever(float value, float value2)
        {

        }
    }
}
