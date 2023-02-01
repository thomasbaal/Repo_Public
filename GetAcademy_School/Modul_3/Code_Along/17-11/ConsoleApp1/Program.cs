using ConsoleApp1;
using static System.Console;

// Hotell
// Ansatte
// Rom


Hotell mittHotell = new Hotell("Tower_Thomas");
Gjest gjest = new Gjest("Anders");
mittHotell.Booking(gjest, mittHotell.Roms[1]);
ReadLine();