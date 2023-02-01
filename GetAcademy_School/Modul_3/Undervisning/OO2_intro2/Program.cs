using OO2_intro2;
using static System.Console;

// Todo: creating a before and after on each scenario.

// Todo 1: Create descriptive classes as needed. 
// Todo 2: Move data / variables / sources to its own relative class.
// Todo 3: Clean up messy code by extracting them to methods.



//Todo: after 4 - innebygde lister av alle typer med List<> | <T> //////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////
var namesY = new List<string>(); // defining data-type <string>,<int> Etc.
var numbersY = new List<int>();

while (true)
{
    Write("Skriv et navn da vel !: ");
    var name = ReadLine();
    namesY.Add(name);
    WriteLine("Skriv in et tall da vel !");
    var strNumber = ReadLine();
    var number = Convert.ToInt32(strNumber);
    numbersY.Add(number);
    WriteLine(String.Join(", ", namesY));
    WriteLine(String.Join(", ", numbersY));
}

ReadLine();





//Todo: after 3 - Introducing Generics!! <T> //////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////
//var namesX = new SuperFlexList<string>(); // defining data-type <string>,<int> Etc.
//var numbersX = new SuperFlexList<int>();

//while (true)
//{
//    Write("Skriv et navn da vel !: ");
//    var name = ReadLine();
//    namesX.Add(name);
//    WriteLine("Skriv in et tall da vel !");
//    var strNumber = ReadLine();
//    var number = Convert.ToInt32(strNumber);    
//    numbersX.Add(number);
//    WriteLine(namesX.GetValues());
//    WriteLine(numbersX.GetValues());
//}

//ReadLine();
///////////////////////////////////////////////////////////////////////////////////



//Todo: after 2 - text: ///////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////

//var names = new StrFlexList();
//while (true)
//{
//    Write("Skriv et navn da !: ");
//    var name = ReadLine();
//    names.AddName(name);

//    WriteLine(names.GetValues());
//}

//ReadLine();
/////////////////////////////////////////////////////////////////////////////////








//Todo: after 1 - tall:
/////////////////////////////////////////////////////////////////////////////////

//var numbers = new IntFlexList();
//while (true)
//{
//    Write("Skriv et tall: ");
//    var strNumbers = ReadLine();
//    var number = Convert.ToInt32(strNumbers);
//    numbers.AddName(number);

//    WriteLine(numbers.GetValues());
//}

//ReadLine();
/////////////////////////////////////////////////////////////////////////////////


//Todo: Before
/*
 var _numbers = new int[4];
var count = 0;

while (true)
{
    Write("Skriv et tall: ");
    var str_numbers = ReadLine();
    var number = Convert.ToInt32(str_numbers);
        if (count >= _numbers.Length)
        {
            //Array.Resize(ref _numbers, _numbers.Length*2); -> showing you what this really does.
            var new_numbers = new int[_numbers.Length]; // it creates a new array.
            Array.Copy(_numbers, new_numbers, _numbers.Length); // copy the values from old array to new array.
            _numbers = new_numbers; // new_numbers are then refering to the _numbers array.
            WriteLine($"Doubling the capacity from {_numbers.Length} to {new_numbers.Length}");
            _numbers = new_numbers;
        }
    _numbers[count] = number;
    count++;
    WriteLine(String.Join(", ", _numbers));
}

ReadLine();
 */