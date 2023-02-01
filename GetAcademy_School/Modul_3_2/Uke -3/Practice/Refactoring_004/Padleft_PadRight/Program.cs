using Refactoring;
using static System.Console;

/*
bra!
    - ta bort tom constructor om du ikke bruker den. Generelt: ikke legg til kode "som du kanskje får bruk for senere". Legg til kode for det du skal løse - ikke noe mer
    - Ikke kall PrintResult fra CountString men fra Program
    - jeg ville fortsatt byttet til char.IsLetter på første if i Countstring
    - PrintResult skal ikke ha parametre (hvor skal verdiene hentes fra da?)
-Du kunne forenklet litt i Program. ser ikke behov for egen metode Display. Skjønner ikke helt padding-greia
ellers ser det greit ut
*/

public class Exercise7
{
    public static void Main(string[] args)
    {
        var msg = "Count all alphabetical letters, empty spaces, special character and digits :";
        WriteLine(msg);
        var inputStr = ReadLine();

        var letterCounts = new LetterCounts(0, 0, 0, 0);
        letterCounts.CountString(inputStr);
        letterCounts.PrintResult();

        ReadLine();
    }


   

   

}





