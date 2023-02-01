using static System.Console;


// Todo:
//
/*
Mall 
Store - Product
Customers
Employe
Toilets
Atm
Information
Doors -> entrances / fire exits
Parkinglots


*/
using Deleteme;

var Nordbyen = new Mall("Nordbyen Kjøpesenter");
var Wallmart = new Store("Meny");
var Europris = new Store("Europris");
Nordbyen.AddStoreToList(Wallmart);
Nordbyen.AddStoreToList(Europris);
// Print out all stores in the mall

// setup this to take inputs and put store to mall list and display info automatically.
while (true)
{
    
    WriteLine("Type the name of the store to add ?");
    string nameOfStore = ReadLine();
    var storeName = new Store(nameOfStore);
    Nordbyen.AddStoreToList(storeName);
    
    Nordbyen.DisplayInfo();
}



ReadLine();