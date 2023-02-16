using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Refactoring
{
    public class LetterCounts
    {
        public int Letters { get; private set; }
        public int Spaces { get; private set; }
        public int Specials { get; private set; }
        public int Digits { get; private set; }

       
       public LetterCounts(int letters, int spaces, int specials, int digits)
        {
            Letters = letters;
            Spaces = spaces;
            Specials = specials;
            Digits = digits;
        }

        public void CountString(string inputStr)
        {
            foreach (var c in inputStr)
            {
                if(char.IsLetter(c)) Letters++;
                else if (char.IsDigit(c)) Digits++;
                else if (char.IsWhiteSpace(c)) Spaces++;
                else Specials++;
            }

        }

       
        public void PrintResult()
        {
            WriteLine($"num of letters :{Letters}\nnum of spaces :{Spaces}\nnum of specials :{Specials}\nnum of digits :{Digits}\n");
        }


    }
}
