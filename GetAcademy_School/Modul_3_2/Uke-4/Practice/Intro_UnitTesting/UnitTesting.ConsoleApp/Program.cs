using UnitTesting.ConsoleApp;

// bruker top level statements
var stats = new Stats();
while (true)
{
    Console.Write("Skriv et tall :");
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    stats.Add(number);
    Console.WriteLine(stats.GetDescription());

}