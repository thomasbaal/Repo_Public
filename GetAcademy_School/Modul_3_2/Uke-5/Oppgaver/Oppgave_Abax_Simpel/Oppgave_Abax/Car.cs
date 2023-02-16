using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abax
{
    public class Car : BaseVehiclesWithMaxSpeed
    {
        private string _color;
        private bool _isLightVehicle;
        // send videre det som ikke blir snappet opp her

        public Car(string regNumber, int effect, int maxSpeed, string color, bool isLightVehicle)
        : base(regNumber, effect, maxSpeed) // <- sendt videre til BaseVehicleWithMaxSpeed, (regNumber)blir lagret i BaseVehicle for BaseVehicleWithMaxSpeed
                                            // arver fra BaseVehicle
        {
            _color = color;
            _isLightVehicle = isLightVehicle;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"** Bil **");

                if (_isLightVehicle)
                {
                    Console.WriteLine($"Lett Kjøretøy");
                }
                else
                {
                    Console.WriteLine("Ikke Spesifisert");
                }

            Console.WriteLine($"Farge : {_color}");
            base.PrintInformation();

        }

        public override void Run()
        {
            Console.WriteLine("Bilen kjører");
        }
    }
}
