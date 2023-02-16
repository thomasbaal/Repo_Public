using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Truck : Vehicle
    {
        private int _numOfAxles{ get; }
        public Truck(string make, string model, int year, int numOfAxles) 
            : base(make, model, year)
        {
            _numOfAxles = numOfAxles;
        }

        public override void Drive()
        {
            Console.WriteLine("The truck is driving");
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}\nNumber of Axles :{_numOfAxles}";
        }

      
    }
}
