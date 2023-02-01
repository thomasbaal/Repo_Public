using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holly
{
    internal class Rom
    {
        public int _roomNumber { get; private set; }
        public bool Isavailable { get; private set; }


        public Rom(int roomNumber, bool isAvailable = true)
        {
            _roomNumber= roomNumber;
            Isavailable= isAvailable;
        }

        

    }
}

