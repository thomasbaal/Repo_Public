using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }

        public Car(string brand, string model, DateTime productionDate)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;

        }

    }
}
