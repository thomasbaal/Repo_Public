using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Oppgave_Ordgåter
{
    public class FindMatches
    {
        public int NumOfWordsToDisplay = 50;
        public readonly Random rand = new Random();
        List<string> SortedList = new List<string>();
        public int Cutlength = 3;
        private List<string> _unsortedList = new List<string>();
        private int numOfTimesAskedForRandomWord = 0;
        private string randomWord = string.Empty;
        private int _wordsChecked = 0;
        public void PrintDifferentRandomWords()
        {
            var word3 = string.Empty;
             SourceData.StoreDataFromFileAndDistinct();
            _unsortedList = SourceData.liDistinct2;

            ListFilter(_unsortedList);
            var lastWord = string.Empty;
            var word1 = string.Empty;
            GetRandomWord();

            while (NumOfWordsToDisplay > 0)
            {
                
                //for (int i = 0; i < fromArrayMethod.Length; i++) WriteLine($"Nr. :{i} : {fromArrayMethod[i].PadLeft(15, ' ')} | CharCount : {fromArrayMethod[i].Length}");
                foreach (var word in SortedList)
                {
                    if (!IsfirstWordSubEndEqualToSecondWordSubStart(randomWord, word)) continue;
                    
                        NumOfWordsToDisplay--;
                        WriteLine($"{randomWord} - {word}");
                        randomWord = word;
                        

                }

            }
            
            bool IsfirstWordSubEndEqualToSecondWordSubStart(string word1, string wordToCheckAgainst)
            {
                var firstWordSubEnd = word1.Substring(word1.Length -3);
                var secondWordSubStart = wordToCheckAgainst.Substring(0, 3);
                _wordsChecked++;
                return firstWordSubEnd == secondWordSubStart;
                    
            }
            WriteLine(_wordsChecked);
        }

        public void GetRandomWord()
        {
            randomWord = SortedList[rand.Next(SortedList.Count)];
            numOfTimesAskedForRandomWord++;
            
                
            
        }

        void ListFilter(List<string> list)
        {
            foreach (var word in list) 
            {
                if (word.Length > 5 && word.Length < 14) SortedList.Add(word); 
            }

        }


    }
}
               