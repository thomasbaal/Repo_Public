using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abax
{
    internal class Boat : BaseVehiclesWithMaxSpeed
    {
        private int _grossWeight;

        public Boat(string regNumber,int enginePower, int maxSpeed, string maxSpeedUnits, int grossWeight ) 
            : base(regNumber,enginePower,maxSpeed,maxSpeedUnits)
        {
            _grossWeight = grossWeight;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"Egenvekt : {_grossWeight}");
            base.PrintInformation();   
        }

        public override void Run()
        {
            Console.WriteLine("Båten seiler");
        }
    }
}
