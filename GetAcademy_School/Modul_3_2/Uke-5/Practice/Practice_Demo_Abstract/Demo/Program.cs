using Demo;

List<Vehicle> vehicles = new List<Vehicle>
{
    new Car("Mercedes", "Benz", 1998, 5),
    new Car("Toyota", "Avensis", 1976, 5),
    new Truck("Volvo","hunter",2002,2),
    new Bike("Honda", "G-Runner", 2018, 2)
};
int listCount = 1;
foreach (var vehicle in vehicles)
{
    vehicle.PrintInfo(vehicle.GetInfo(), listCount);
    listCount++;
    
}

Console.ReadLine();

