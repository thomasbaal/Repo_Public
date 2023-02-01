using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Holly
{
    internal class Hotel
    {
        private string _name { get; set; }
        public List<Rom> _liHotellRooms{ get; private set; }
        private List<Guest> _liGuests { get; set; }
        private List<Employee> _liEmployees { get; set; }


        public Hotel(string name)
        {
            _name= name;
            _liHotellRooms= new List<Rom>();
            _liGuests= new List<Guest>();
            _liEmployees= new List<Employee>();
            GenerateRooms();
        }
        public void Booking(Guest guest, Rom rom)
        {
            _liGuests.Add(guest);

        }



        private void GenerateRooms()
        {
            int floorNumber;
            int roomNumber;
            for (floorNumber = 1; floorNumber < 4; floorNumber++)
            {
                for (roomNumber = 1; roomNumber < 7; roomNumber++)
                {
                   _liHotellRooms.Add(new Rom(Convert.ToInt32(floorNumber.ToString()+ "0" + roomNumber.ToString()),GenerateTrueOrFalse()));
                }
            }
        }
        
        private bool GenerateTrueOrFalse()
        {
            bool isAvailable;
            Random r = new Random();
            var rand = r.Next(0, 2);
            if(rand == 0) isAvailable= true;
            else isAvailable= false;

            return isAvailable;
        }


        public IEnumerable CheckIfRoomIsAvailable()
        {
            var availableRooms = from room in _liHotellRooms where
                room.Isavailable == true
                select room;
            
            return availableRooms;
        }
        public IEnumerable CheckWitchRoomsAreOccupied()
        {
            var occupiedRooms = from room in _liHotellRooms where
                room.Isavailable != true
                select room;

            return occupiedRooms;
        }

    }
}
