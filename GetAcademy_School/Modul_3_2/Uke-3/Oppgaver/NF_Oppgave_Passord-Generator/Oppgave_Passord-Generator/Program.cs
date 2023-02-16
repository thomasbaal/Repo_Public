using static System.Console;


// ( l - liten bokstav, L - stor bokstav, d -tall og s- spesialtegn)

// passordet skal bestå av 14 tegn, med en liten bokstav, en storbokstav, to spesialtegn og to tall
// send in 14 lLssdd







class Program
{
    public static void Main(string[] args)
    {
        if (CheckIfValid(args))
        {
            // Check if args[0] is a number
            if (CheckIfNumber(args[0]))
            {

            }
            else
            {
                ShowMenu();
            }

        }
        ReadLine();

    }

    public static bool CheckIfValid(string[] args)
    {
        if (args.Length != 2) return false;
        return true;
    }


    public static bool CheckIfNumber(string args1)
    {
        foreach (var c in args1)
        {
            if(!char.IsNumber(c)) return false;
        }
        return true;
    }





    public static void ShowMenu()
    {
        WriteLine(@"
        PasswordGenerator

        Options:
        -l = lower case letter
        - L = upper case letter
        - d = digit
        - s = special character !\""#¤%&/(){}[]
        Example: PasswordGenerator 14 lLssdd
        Min. 1 lower case
        Min. 1 upper case
        Min. 2 special characters
        Min. 2 digits


        ");



    }

}

