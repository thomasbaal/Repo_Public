using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abax
{
    public abstract class BaseVehiclesWithMaxSpeed : BaseVehicle
    {
        private int _maxSpeed;
        private string _maxSpeedUnit;

        public BaseVehiclesWithMaxSpeed(string regNumber, int effect, int maxSpeed, string maxSpeedUnit = "Km/t")
        :base(regNumber, effect) // <- sendt videre til BaseVehicle.
        {
            _maxSpeed = maxSpeed;
            _maxSpeedUnit = maxSpeedUnit;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Maks Hastighet : {_maxSpeed} {_maxSpeedUnit}");
            base.PrintInformation();
        }

    }
}
