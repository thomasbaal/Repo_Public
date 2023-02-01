using static System.Console;

    ShowSeperator();
    ShowInfo(2, 10, 43,  "Thomas", "Blæsrøden", "Lunkedalskogen");
    ShowSeperator();
    ShowInfo(2, 10, 33,  "Andrea", "Blæsrøden", "Lunkedalskogen");
    ShowSeperator(2);
    
    ReadLine();

    




static void ShowSeperator()
{
    WriteLine("*************************");
}

static void ShowSeperator(int width)
{
    width = width * 2;
    WriteLine("*************************");
}
static void ShowInfo(int padLeft,int padLeft_2, int age, string firstName, string lastName, string address)
{
    //padLeft_2 -= firstName.Length;
    WriteLine($"{string.Empty.PadLeft(padLeft, ' ')}Firstname: {string.Empty.PadLeft(padLeft_2, ' ')}{firstName}");
    WriteLine($"{string.Empty.PadLeft(padLeft, ' ')}Lastname: {string.Empty.PadLeft(padLeft_2, ' ')}{lastName}");
    WriteLine($"{string.Empty.PadLeft(padLeft, ' ')}Adress: {string.Empty.PadLeft(padLeft_2, ' ')}{address}");
}















