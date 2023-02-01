using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rom
    {
        public int DoorNumber { get; private set; }
        public Gjest Gjest { get; private set; } 
        public Rom(int doorNumber)
        {
            DoorNumber= doorNumber;

        }

        public void AddGuestToRoom(Gjest gjest)
        {
            Gjest = gjest;
        }
    }
}
