using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Car : Vehicle
    {
        private int _numOfDoors { get; }
        public Car(string make, string model, int year, int numOfDoors) 
            : base(make, model, year)
        {
            _numOfDoors = numOfDoors;
        }

        public override void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public override string GetInfo()
        {
            
            //return $"{base.GetInfo()}\nNumber of doors :{_numOfDoors.ToString()}";
            return $"{base.GetInfo()}\nNumber of doors :{_numOfDoors}";
        }

       
    }
}
