using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Bike : Vehicle
    {
        private int _numOfWheels { get; } = 2;
        public Bike(string make, string model, int year, int numOfWheels) 
            : base(make, model, year)
        {
            _numOfWheels = numOfWheels;
        }

        public override void Drive()
        {
            Console.WriteLine("The bike is running");
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}\nNumber of wheels : {_numOfWheels}";
        }

       
    }
}
