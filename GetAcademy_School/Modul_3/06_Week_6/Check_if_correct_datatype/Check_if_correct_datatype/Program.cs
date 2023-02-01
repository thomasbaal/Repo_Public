using static System.Console;

// Note !: The TryParse method is like the Parse method, except the TryParse method does not throw an exception if the conversion fails.


char a = 'a';
string str1 = "Whatever";
string stringAsANumber = "123";
double temp = 1.2d;
decimal price1 = 12.2m;
decimal price2 = 72.2m;
int num = 123;

string[] values = new string[] { null, "160519", "9432.0", "16,667","   -322   ", "+4302", "(100); ", "01FA " };  

// string with numbers to int
bool stringToInt1 = int.TryParse(stringAsANumber, out num); 
WriteLine(stringToInt1); // True.

// string with letters to int
bool stringToInt2 = int.TryParse(str1, out num);
WriteLine(stringToInt2); // True.

// Loop to show conversions.
WriteLine("Conversion loop ---------------");
foreach (var value in values)
{
    int number;
    bool resultOfParse = int.TryParse(value, out number);
    if (resultOfParse)
    {
        WriteLine($"{value} was converted successfully to an < Int > - New Int Value: {number} \n|");
    }
    else
    {
        WriteLine($"The attempt to convert '{value ?? "<null>"}' to an Int failed ! \n|");
    }
}
/*
 * "9432.0". The conversion fails because the string cannot contain a decimal separator; it must contain integral digits only.

   "16,667". The conversion fails because the string cannot contain group separators; it must contain integral digits only.
 * 
 * 
 True
False
The attempt to convert '<null>' to an Int failed !
|
160519 was converted successfully to an < Int > - New Int Value: 160519
|
The attempt to convert '9432.0' to an Int failed !
|
The attempt to convert '16,667' to an Int failed !
|
   -322    was converted successfully to an < Int > - New Int Value: -322
|
+4302 was converted successfully to an < Int > - New Int Value: 4302
|
The attempt to convert '(100); ' to an Int failed !
|
The attempt to convert '01FA ' to an Int failed !
|
 */




WriteLine();

ReadLine();