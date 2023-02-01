
// 

using Linq_Testing;

var listOfCountries = CountryData.CreateCountries();
var print = new Print();

var infotext = "ett eller annet her";

StartsWith2(listOfCountries, print, infotext);

StartsWith(listOfCountries, print);

SearchContains(listOfCountries, print);

PopulationAbove(listOfCountries, print);

PopulationBelow(listOfCountries, print);

OrderList(listOfCountries, print);


Console.ReadLine();


void StartsWith2(Country[] countries, Print print1, string infotext)
{
    Console.WriteLine(infotext);
    string userCommand = Console.ReadLine();
    var searchResult = "";
    if (userCommand[0].ToString() == "s")
    {
        searchResult = ListHandler.StartsWith(countries, userCommand.ToUpper());

    }
    print1.PrintResult(searchResult);
}


void StartsWith(Country[] countries, Print print1)
{
    Console.WriteLine("Search Starts With !");
    string userCommand = Console.ReadLine();
    var searchResult = ListHandler.StartsWith(countries, userCommand.ToUpper());
    print1.PrintResult(searchResult);
}

void SearchContains(Country[] listOfCountries1, Print print2)
{
    Console.WriteLine("Search contains ?");
    string userCommand = Console.ReadLine();
    var searchContainsResult = ListHandler.Contains(listOfCountries1, userCommand.ToUpper());
    print2.PrintResult(searchContainsResult);
}

void PopulationAbove(Country[] countries1, Print print3)
{
    Console.WriteLine("Population above ?");
    string userCommand = Console.ReadLine();
    if (int.TryParse(userCommand, out int numToSearch))
    {
        var searchPopulationAboveResult = ListHandler.PopulationAbove(countries1, numToSearch);
        print3.PrintResult(searchPopulationAboveResult);
    }
}

void PopulationBelow(Country[] listOfCountries2, Print print4)
{
    Console.WriteLine("Population Below ?");
    var userCommand = Console.ReadLine();
    if (int.TryParse(userCommand, out int numberToSearch))
    {
        var searchPopulationBelowResult = ListHandler.PopulationBelow(listOfCountries2, numberToSearch);
        print4.PrintResult(searchPopulationBelowResult);
    }
}

void OrderList(Country[] countries2, Print print5)
{
    Console.WriteLine("Order list by Ascending or Descending Name");
    Console.WriteLine("1. Ascending.\n2. Descending");
    var userCommand = Console.ReadLine();
    if (int.TryParse(userCommand, out int numberChoice))
    {
        if (numberChoice == 1)
        {
            var listOfNamesAsending = ListHandler.CreateAscendingList(countries2);
            print5.PrintResult(listOfNamesAsending);
        }

        if (numberChoice == 2)
        {
            var listOfNamesDescending = ListHandler.CreateDescendingList(countries2);
            print5.PrintResult(listOfNamesDescending);
        }
    }
}