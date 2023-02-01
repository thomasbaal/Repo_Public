using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holly
{
    internal class Guest
    {
        public string Name { get; private set; }
        public List<Rom> LiGuestRooms { get; private set; }
        public Guest(string name)
        {
            Name= name;
        }
        public void Booking(Rom rom)
        {
            LiGuestRooms.Add(rom);
        }

    }
}
