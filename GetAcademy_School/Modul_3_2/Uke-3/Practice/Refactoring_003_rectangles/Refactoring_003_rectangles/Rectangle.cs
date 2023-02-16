using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring_003_rectangles
{
    public class Rectangle
    {
        private double _k1 { get; set; }
        private double _k2 { get; set; }
        public double _hypotenus { get; private set; }
        public Rectangle(double k1, double k2)
        {
            _k1 = k1;
            _k2 = k2;
            _hypotenus = CalcHyp();
        }

        public double CalcHypotenus(double sideA, double sideB)
        {
            var hypotenus = Math.Sqrt(Math.Pow(sideA,2) + Math.Pow(sideB,2));   

            return hypotenus;
        }
        public double CalcHyp()
        {
            return Math.Sqrt(Math.Pow(_k1, 2) + Math.Pow(_k2, 2));
        }



    }
}
