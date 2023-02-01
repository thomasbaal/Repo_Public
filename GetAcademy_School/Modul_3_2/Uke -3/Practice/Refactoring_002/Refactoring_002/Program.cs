using static System.Console;
namespace Refactoring_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeColor(ConsoleColor.Yellow, ConsoleColor.DarkBlue);
            var name = Ask("What is your name ?");
            var age = AskForAge("What is your age ?");
            
        }

        private static int AskForAge(string question)
        {
            var strAge = Ask(question);
            var age = Convert.ToInt32(strAge);  
            return age;
        }


        private static string Ask( string question)
        {
            
            WriteLine(question);
            return ReadLine();

        }

        private static void ChangeColor(ConsoleColor color1, ConsoleColor color2)
        {
            Console.ForegroundColor = color1;
            Console.BackgroundColor = color2;
        }


    }
}