using _101_Linq_samples;
using static System.Console;

var people = new List<Person>
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
        2345),
    new Person(
        3,
        "Espen",
        "Olsen",
        new DateTime(1992, 5, 6),
        3456),
};






// FirstOrDefault - forste som...
// FirstOrDefault without specifing value to look for will return first query in list.
var firstPersonInList = people.FirstOrDefault();
WriteLine(firstPersonInList.FirstName); // Per

var personWhoIsBornBefore1991 = people.FirstOrDefault(p => p.BirthDay.Year < 1991);
WriteLine(personWhoIsBornBefore1991.FirstName + " " +personWhoIsBornBefore1991.BirthDay.Year);// Per 1990

Person personWhoIsBornBefore1991x = null;
foreach (var p in people)
{
    if (p.BirthDay.Year < 1990)
    {
        personWhoIsBornBefore1991x = p; // copying objects that fit the statements into this variable.
        break; // break here means it will stop looping and add only the first result to the variable.
    }
}


//SingleOrDefault..
// this function returns error if it finds more than one with the spcified value.
// So its wise to use this on unique values like "Id's"
var personWidthId2 = people.SingleOrDefault(p => p.Id == 3);
WriteLine(personWidthId2.FirstName);


// Where, About the same as filter in Javascript.
var peopleWithFirstNameWithLetterE = people.Where(p => p.FirstName.ToLower().Contains("e"));
// Same as above but WITHOUT LINQ.
var peopleWithFirstNameWithLetterEx = new List<Person>();
foreach (var person in people)
{
    if (person.FirstName.ToLower().Contains("e"))
    {
        peopleWithFirstNameWithLetterEx.Add(person);
        WriteLine($"{person.FirstName} added to list");
    }
}

// ToList() and ToArray() with the use of where.
var queryList = people.Where(p => p.FirstName.ToLower().Contains("e")).ToList();
var queryArray = people.Where(p => p.FirstName.ToLower().Contains("e")).ToArray();



// SELECT (About the same as map() in Javascript)
var firstNames1 = people.Select(p => p.FirstName).ToList();// firstNames1 is now a LIST!
WriteLine(firstNames1[0]);
var firstNames2 = people.Select(p => p.FirstName).ToArray(); // firstNames2 is now an ARRAY!
// same as above but WITHOUT ! Linq.
var firstNamesx = new List<string>();
foreach (var person in people)
{
    firstNamesx.Add(person.FirstName);
}

// Where and Select used simultaniously.
var firstNamesOfPeopleBornBefore1992 = people
    .Where(p => p.BirthDay.Year < 1992)
    .Select(p => p.FirstName).ToList(); // or ToArray();
//Same as above but WITHOUT ! Linq.
var personWhoIsBornBefore1992x = new List<string>();
foreach (var p in people)
{
    if (p.BirthDay.Year < 1992)
    {
        personWhoIsBornBefore1992x.Add(p.FirstName);
    }
}

// Sum, Min, Max
// Sum:
var sumOfPeoplesAges = people.Select(p => p.Age).Sum();
WriteLine(sumOfPeoplesAges); // 93.

ReadLine();