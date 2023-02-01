using Linq_Practice;
using System.Runtime.CompilerServices;
using static System.Console;

// Note !..
/*
Where is used for filtering the collection based on given criteria.
Multiple Where extension methods are valid in a single LINQ query.

Select always return an IEnumarable collection.
 */
DataSource.GetNames();
List<Person> listOfPeople = new List<Person>();





for (int i = 0; i < 1000 -1; i++)
{
    var newPerson = new Person(DataSource.GetFirstName(), DataSource.GetLastName(), DataSource.GetBirthYear(), DataSource.GetGuid());
    AddToList(newPerson);
}
void AddToList(Person person)
{
    listOfPeople.Add(person);
}
//WriteLine(DataSource.CheckfirstNamesAndLastNamesEquality());


// Every Name is in Uppercase by defaut...
var firstNameThatStartsWithALowerCase = listOfPeople.FirstOrDefault(p => p.FirstName.ToLower().StartsWith("a")); // Adam
var firstNameThatStartsWithA = listOfPeople.FirstOrDefault(p => p.FirstName.StartsWith("a")); // null

var thelastLastnameThatStartsWitha  = listOfPeople.LastOrDefault(p => p.FirstName.ToLower().StartsWith("a")); // Aurora

// Check if above 18
var ageToCheck = 18;
var above182 = listOfPeople.Where(p => p.BirthYear > (DataSource.GetYear(ageToCheck)));
var filterAbove18 = from p in listOfPeople where p.BirthYear > (DataSource.GetYear(ageToCheck)) select p;

// check if between 18 - 21
var ageFirst = 18;
var ageSecond = 21;
var filterBetween18And21 = listOfPeople.Where(p =>
    p.BirthYear < (DataSource.GetYear(18)) && p.BirthYear > (DataSource.GetYear(ageSecond)));


/////////////////////////////////////////////////////// - Select - //////////////////////////////////////////////////////////
// select have several other options like, all,many,any
var collectionOfFirstNames = from p in listOfPeople select p.FirstName; // all of them, but will only show the value of FirstName.
var collectionOfGuids = from p in listOfPeople select p.Guid; // all Guids.

////////////////////////////////////////////////////// - Contains - ////////////////////////////////////////////////////////
/// Contains
var contains_ri = from p in listOfPeople where p.FirstName.Contains("ril") select p; // Tiril E.t.c

////////////////////////////////////////////////////// - Average - ////////////////////////////////////////////////////////
// Average
var avgBirthYear = listOfPeople.Average(p => p.BirthYear); // avgBirthYear=1987.8788788788788
WriteLine();

////////////////////////////////////////////////////// - Multiple select and where operator - ////////////////////////////////////////////////////////
//
var listofTest1 = listOfPeople.Where(p => p.BirthYear < 1970).Select(p => p)
    .Where(pId => pId.Guid != null)
    .Select(p => p.FirstName);

var listOfTest2 = listOfPeople.Where(p => p.Guid.StartsWith(19.ToString())).Select(p => p.Guid); // 19f43bb0-42d6-4d04-978e-7bac4b6fe6bb E.T.C
 
void DemoLink()
{
    //listOfPeople.FirstOrDefault(p => p.)
}

ReadLine();