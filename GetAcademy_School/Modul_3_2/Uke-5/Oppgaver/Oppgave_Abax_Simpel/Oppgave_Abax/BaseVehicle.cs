using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave_Abax
{
    public abstract class BaseVehicle
    {
        private string _registrationNumber;
        private int _enginePower;

        public BaseVehicle(string regNumber, int effect)
        {
            _registrationNumber = regNumber;
            _enginePower = effect;
        }
        public virtual void PrintInformation()
        {
            Console.WriteLine($"Registrerings Nummer : {_registrationNumber}");
            Console.WriteLine($"Motor Effekt: {_enginePower}");
        }

        public virtual void Run()
        {
            Console.WriteLine();
        }
    }
}
