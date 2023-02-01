using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Intro_til_Csharp_og_Visual_studio_del_2_oppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             // ?? = null, means: if txt is null use string.empty (this to not get error)
             // explained in more detail:
             // (int)character <- this becomes the index, first letter is s (int) hard convert this to 115, the ++ just adds 1 on each iteration.
             // (as ++ is stored to a array index position.
             // so the first value will be AT! Index 115 with the value of 1..
             // the next witch is the letter "o" will be at index "111" with the value of 1
             // if the text had 2 equal character of "a" it would runn ++ 2 times at that index, so the value at taht position would be 2!!!
             // (int) = casting, a hard convert of datatype.-> if you put in a character "g" it checks scii code table
             // then that number will be added to teh "counts" array.
             */
            var range = 250;
            ReadTextAndUpdateAndShowCharCounts(range);
        }

        private static void ReadTextAndUpdateAndShowCharCounts(int range)
        {
            var counts = new int[range];
            string text = "analalfabet";

            while (!string.IsNullOrWhiteSpace(text))
            {
                UpdateChar(text, counts);
                ShowCounts(range, counts);
            }
        }

        private static void ShowCounts(int range, int[] counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    WriteLine(character + " - " + counts[i]);
                }
            }
        }

        private static void UpdateChar(string text, int[] counts)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
        }
    }
}
