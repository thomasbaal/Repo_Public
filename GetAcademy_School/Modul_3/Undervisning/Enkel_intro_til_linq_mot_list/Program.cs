using Enkel_intro_til_linq_mot_list;
using static System.Console;




var people = new List<Person>()
{
    new Person(
        1,
        "Per",
        "Hansen",
        new DateTime(1990, 1, 2),
        1234),
    new Person(
        2,
        "Pål",
        "Nilsen",
        new DateTime(1991, 3, 4),
        1234),
    new Person(
        3,
        "Espen",
        "Nilsen",
        new DateTime(1992, 3, 4),
        1234),
    new Person(
        4,
        "Erik",
        "Wimsickle",
        new DateTime(1990, 3, 1),
        1234),

};


// FirstOrDefault - første som.
// SingleOrDefault - den ene som...
// where (tilsvarer filter i javascript)
// Select (tilsvarer map i javascript)
// Sum, Min, Max

var firstPersonInList = people.FirstOrDefault();

// One liner kode med "lamda expression.
var personWhoIsBornBefore1991 = people.FirstOrDefault(p => p.BirthDay.Year < 1991); 


// One liner koden over ka gjøre mer tungvint : som under:

// merk, vi skal lete etter et objekt "Person"

Person personWhoIsBornBefore1991x = null;       // trekk ut dette til metode....
foreach (var p in people)                       // trekk ut dette til metode....
{                                               // trekk ut dette til metode....
    if(p.BirthDay.Year < 1991)                  // trekk ut dette til metode....
    {                                           // trekk ut dette til metode....
        personWhoIsBornBefore1991x = p;         // trekk ut dette til metode....
        break;                                  // trekk ut dette til metode....
    }                                           // trekk ut dette til metode....
}                                               // trekk ut dette til metode....

//til metode.. (år som parameter
var personBefore = FindPersonBeforex(1991);

Person FindPersonBeforex(int year)
{
    var personWhoIsBornBefore1991 = people.FirstOrDefault(p => p.BirthDay.Year < year);
    return personWhoIsBornBefore1991;

}

var personWithId2 = people.SingleOrDefault(p => p.Id == 2);
WriteLine(personWithId2.FirstName + " " + personWithId2.LastName); // Pål Nilsen

WriteLine($"{personBefore.FirstName} {personBefore.LastName}"); // Per Hansen.



//////////////////////////////////////////////////////////////////////////////////////////////
// lambda expression - find in list firstname that contains the letter "e"
var peopleWithFirstNameWithLettersE = people.Where(p => p.FirstName.ToLower().Contains("e")).ToList();




//////////////////////////////////////////////////////////////////
// Non lambda version - look for and add to list :
var peopleWithFirstNameWithLettersEx = new List<Person>();
foreach (var p in people)
{
    if (p.FirstName.ToLower().Contains("e"))
    {
        peopleWithFirstNameWithLettersEx.Add(p);
    }
}

////////////////////////////////////////////////////////////////////////
//Select - with linq: Create a list with firstnames.
var firstNames = people.Select(p => p.FirstName).ToList();

// without linq.
var firstNamesx = new List<string>();
foreach (var p in people)
{
    firstNamesx.Add(p.FirstName);
}

//select og where
var firstNamesOfPeopleBornBefore1992 = people // <- firstNamesOfPeopeBornBefore1992: dette er en liste som blir laget automatisk med liqn metodene.
    .Where(p => p.BirthDay.Year < 1992)
    .Select(p => p.FirstName).ToList();
WriteLine("Where og select " + firstNamesOfPeopleBornBefore1992[2]);

//sum, min, max

//sum
var sumOfPeopleAges = people.Select(p => p.Age).Sum();



WriteLine();

ReadLine();