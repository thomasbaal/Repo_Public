using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gjest
    {
        public string Name { get; private set; }
        public List<Rom> Roms { get; private set; }

        public Gjest(string name)
        {
            Name = name;
            Roms = new List<Rom>();

        }

        public void Booking(Rom rom)
        {
            Roms.Add(rom);

        }

    }
}
