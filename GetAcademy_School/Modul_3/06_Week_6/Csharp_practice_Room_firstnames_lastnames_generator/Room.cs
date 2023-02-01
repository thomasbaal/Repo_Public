using static System.Console;

// See https://aka.ms/new-console-template for more information
public class Room
{
	public int RoomId { get; private set; }	
	public int NumOfDoors { get; set; }
	public bool IsAvailable { get; set; }
	public Room(int roomId, int numOfDoors, Boolean isAvailable = false)
	{
		RoomId = roomId;
		NumOfDoors= numOfDoors;
		IsAvailable= isAvailable;
	}
	
}