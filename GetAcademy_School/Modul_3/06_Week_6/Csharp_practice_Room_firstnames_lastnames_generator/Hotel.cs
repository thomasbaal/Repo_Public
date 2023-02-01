using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Deleteme
{
    public class Hotel
    {
        public string Name { get; private set; }
        public List<Room> Li_HotelRooms { get; private set; }
        public List<Employee> Li_Employees { get;  set; }
        public List<Guest> Li_Guests { get; private set; }
        private DataSource _data;
        private QueryHandler _queryHandler;
        public Hotel(string name)
        {
            Name = name;
            Li_HotelRooms = new List<Room>();
            Li_Employees= new List<Employee>();
            Li_Guests = new List<Guest>();
            _data = new DataSource();
                _data.GenerateRooms(this);
                _data.GenerateEmployees(this);
            _queryHandler = new QueryHandler();  
            MenuHandler menuHandler = new MenuHandler(this);
        }

       
    }
}