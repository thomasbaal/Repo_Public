using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abax
{
    internal class Plane : BaseVehicle
    {
        private int _wingSpan;
        private int _loadCapacity;
        private int _weight;
        private string _planeType;
        private string _weightUnits;

        public Plane(string regNumber, int enginePower, int wingSpan, int loadCapacity,int weight, string planeClass, string weightUnits = "Tonn" )
        :base(regNumber,enginePower)
        {
            _wingSpan = wingSpan;
            _loadCapacity = loadCapacity;
            _weight = weight;
            _planeType = planeClass;
            _weightUnits = weightUnits;
        }

        public override void Run()
        {
            Console.WriteLine("Flyet flyr");
        }
    }
}
