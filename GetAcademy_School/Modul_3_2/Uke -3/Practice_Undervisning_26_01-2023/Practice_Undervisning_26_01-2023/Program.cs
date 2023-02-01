using Practice_Undervisning_26_01_2023;
using System.Collections.Generic;



var listStr = new GenericList<string>();
var list = new List();
//Run1(list);


Run2(listStr);

void Run2(GenericList<string> list)
{
    while (true)
    {
        Console.WriteLine("Type a number or letter");
        var commandStr = Console.ReadLine();
        listStr.Add(commandStr);
        listStr.Show();

    }

}


void Run1(List list)
{
    while (true)
    {
        Console.WriteLine("Type a number or letter");
        var commandStr = Console.ReadLine();
        if (int.TryParse(commandStr, out int commandInt))
        {
            list.AddInts(commandInt);
            list.PrintInts();
        }
        else if (char.TryParse(commandStr, out char character))
        {
            list.AddChars(character);
            list.PrintChars();
        }
    }
}



