using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class Vehicle
    {
        private string _make { get; }
        private string _model { get; }
        private int _year { get; }

        public Vehicle(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public abstract void Drive();

        public virtual string GetInfo()
        {
            return $"Make :{_make}\nModel :{_model}\nYear : {_year.ToString()}";
        }

        public void PrintInfo(string vehicleInfo, int listCount)
        {
            Console.WriteLine("----- Vehicle nr : {0} -----", listCount);
            Console.WriteLine($"{vehicleInfo}\n");
            
        }
    }
}
