using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Oppgave_Ordgåter
{
    public static  class SourceData
    {
        public static List<string> liWords = new();
        public static List<string> liWords2 = new();
        public static List<string> liDistinct = new();
        public static List<string> liDistinct2 = new();
        public static void CreateWordList()
        {
            var filePath = @"E:\01_Coding\04_GetAcademy\Modul_3\Oppgaver\Oppgave_Ordgåter\Oppgave_Ordgåter\Ordliste.txt";
            var line = File.ReadAllLines(filePath);
            foreach (var part in line)
            {
                var partsFromLine = part.Split('\t');
                var word = partsFromLine[2];
                if(word.StartsWith('-'))
                {
                    var okWord = word.Substring(1);
                    //WriteLine($"fixed: {okWord}");
                    liWords.Add(okWord);
                }

            }
            liDistinct = liWords.Distinct().ToList();

        }

        public static void StoreDataFromFileAndDistinct()
        {
            var filePath = @"E:\01_Coding\04_GetAcademy\Modul_3\Oppgaver\Oppgave_Ordgåter\Oppgave_Ordgåter\Ordliste_2.txt";
            var line = File.ReadAllLines(filePath);
            foreach (var word in line)
            {

                if (!word.Contains('-'))
                {
                    liWords2.Add(word);
                }


            }
            liDistinct2 = liWords2.Distinct().ToList();
        }
    }
}