using static System.Console;
using Startliste;

var csv_FilePath = "startlist.csv";
var csv_Animals_FilePath = "animals.csv";


//var fruits_FilePath = "fruits.csv";

//var arrFruits = File.ReadAllLines(fruits_FilePath);



using(var sr = new StreamReader("startlist.csv"))
{
    string line;
	while ((line = sr.ReadLine()) != null)
	{
		var registration = new Registration(line);
		list.Add(registration);
	}
}

ReadLine();



