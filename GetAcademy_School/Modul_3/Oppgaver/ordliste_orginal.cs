using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using static System.Console;

namespace Ordgåter
{
    class Program
    {
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            // Velge tilfeldig ord.  - eks: abonnement
            var words = GetWords();
            var wordCount = 200;
            while (wordCount > 0)
            {
                var hasFoundMatch = FindWordProblem(words);
                if (hasFoundMatch) wordCount--;
            }
            ReadLine();
        }

        private static bool FindWordProblem(string[] words)
        {
            var randomWordIndex = Random.Next(words.Length);
            var selectedWord = words[randomWordIndex];
            Console.Write(selectedWord + " - ");

            foreach (var word in words)
            {
                if (!IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(selectedWord, word)) continue;
                Console.WriteLine(word);
                return true;
            }
            Console.WriteLine("<fant ikke match>");
            return false;
        }

        private static bool IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(string word1, string word2)
        {
            return IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(4, word1, word2)
            || IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(5, word1, word2);
        }

        private static bool IsLastPartOfFirstWordEqualToFirstPartOfSecondWord(int commonLength, string word1, string word2)
        {
            // 0123456789
            // abonnement - commonLength == 4
            // "abonnement".Length == 10
            var lastPartOfFirstWord = word1.Substring(word1.Length - commonLength, commonLength);
            // 012345
            // mental
            var firstPartOfSecondWord = word2.Substring(0, commonLength);

            return lastPartOfFirstWord == firstPartOfSecondWord;
        }

        static string[] GetWords()
        {
            var lastWord = string.Empty;
            var filePath = @"E:\01_Coding\021__C#_Testing_and_trying_things\Ordgåter\Ordgåter\ordliste.txt";
            var wordList = new List<string>();
            foreach (var line in File.ReadLines(filePath, Encoding.UTF8))
            {
                var parts = line.Split('\t');
                var word = parts[2];
                string fixedWord = string.Empty;
                if (word.Contains('-'))
                {
                    fixedWord = word.Substring(1);
                }
                    
                if (fixedWord != lastWord
                    && fixedWord.Length > 6
                    && fixedWord.Length < 10
                    && !fixedWord.Contains('-'))
                {
                    wordList.Add(fixedWord);
                }
                lastWord = fixedWord;
            }
            return wordList.ToArray();
        }
    }
}