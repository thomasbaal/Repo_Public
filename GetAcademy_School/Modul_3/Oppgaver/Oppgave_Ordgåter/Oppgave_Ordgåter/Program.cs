using Oppgave_Ordgåter;
using static System.Console;

//var sourceData = new SourceData();
var findMatches = new FindMatches();

//sourceData.CreateWordList();
//wordCreator.CreateListOfWordsBasedOnWantedLength(sourceData.liDistinct);



//sourceData.StoreDataFromFileAndDistinct();

// 2. print diferent random words. - Done
//findMatches.PrintDifferentRandomWords(sourceData.liDistinct2, 200);

// 3,4 Same as above, but dont print them out, put them in a list, create a method with return "Array" with the words. - Done
//findMatches.PrintDifferentRandomWords(sourceData.liDistinct2, 200);
//5.
//findMatches.FindAndListMatches(200, 3, sourceData.liDistinct2); // words to list/find, cutlength, list 

findMatches.PrintDifferentRandomWords();



ReadLine();