using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Deleteme
{
    internal class MenuHandler
    {
        private Hotel _hotel;
        public MenuHandler(Hotel hotel)
        {
            this._hotel= hotel;
        }
        
       public void GuestSearch()
        {
            List<string> li_Result = new List<string>();
            foreach (var item in _hotel.Li_Guests)
            {
                
            }
        }

        public void ListAllHotelRooms()
        {
            foreach (var room in _hotel.Li_HotelRooms)
            {

            }
        }

    }
}
