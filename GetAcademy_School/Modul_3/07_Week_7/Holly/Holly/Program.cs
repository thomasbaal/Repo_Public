using Holly;
using static System.Console;

Hotel hotel1 = new Hotel("Touring-Tower");

Guest guest1 = new Guest("Trond");
Guest guest2 = new Guest("Liam");
Guest guest3 = new Guest("Odd");

var availableRooms = hotel1.CheckIfRoomIsAvailable();
var occupiedRooms = hotel1.CheckWitchRoomsAreOccupied();

WriteLine("Available Rooms");
foreach (Rom room in availableRooms)
{
    WriteLine(room._roomNumber);
}

WriteLine("Occupied Rooms");
foreach (Rom room in occupiedRooms)
{
    WriteLine(room._roomNumber);
}
//hotel1.Booking(guest1, hotel1.CheckIfRoomIsAvailable());




ReadLine();