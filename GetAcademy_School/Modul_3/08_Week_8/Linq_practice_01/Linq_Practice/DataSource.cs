using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Linq_Practice
{
    public class DataSource
    {
        public static List<string> FirstNames = new List<string>();
        public static List<string> LastNames = new List<string>();
        private static Random rand { get; set; }
        public static int _firstNamesAdded;
        public static int _lastNamesAdded;
        private static Guid _guid;
        public static bool _firstNamesAndLastNamesEquality => _firstNamesAdded == _lastNamesAdded ? true : false ;

        public static string GetGuid()
        {
            var guid = string.Empty;
            guid = Guid.NewGuid().ToString();

            return guid;
        }
        public static void GetNames()
        {
            string lineFromBoysNames;
            string lineFromLastNames;
            var filepath = @"E:\01_Coding\021__C#_Testing_and_trying_things\Linq_Practice\Linq_Practice\GuttenavnOgJentenavn.csv";
            var filepath2 = @"E:\01_Coding\021__C#_Testing_and_trying_things\Linq_Practice\Linq_Practice\LastNames.csv";
            using (var sr = new StreamReader(filepath))

            while ((lineFromBoysNames = sr.ReadLine()) != null) 
            {
                FirstNames.Add(lineFromBoysNames);
            }

            using (var sr = new StreamReader(filepath2))

            while ((lineFromLastNames = sr.ReadLine()) != null)
            {
                LastNames.Add(lineFromLastNames);
            }

            ScrambleNames();
        }

        public static void ScrambleNames()
        {
            
            for (int i = FirstNames.Count - 1; i > 0; i--)
            {
                rand = new Random();
                var r = rand.Next(i + 1);
                
                var temp = FirstNames[i];
                FirstNames[i] = FirstNames[r];
                FirstNames[r] = temp;    

            }
            for (int i = LastNames.Count - 1; i > 0; i--)
            {
                rand = new Random();
                var r = rand.Next(i + 1);

                var temp = LastNames[i];
                LastNames[i] = LastNames[r];
                LastNames[r] = temp;

            }

        }
        public static string GetFirstName()
        {
            _firstNamesAdded++;
            //return FirstNames[_firstNamesAdded];

            return FirstNames[rand.Next(FirstNames.Count)];
        }
        public static string GetLastName()
        {
            _lastNamesAdded++;
            //return LastNames[_lastNamesAdded];
            return LastNames[rand.Next(LastNames.Count)];
        }

        public static int GetBirthYear()
        {
            rand = new Random();
            var birthYear = rand.Next(1956, 2022);
            return birthYear;
        }

        public static bool CheckfirstNamesAndLastNamesEquality()
        {
            return _firstNamesAndLastNamesEquality;
        }

        //public static string Display()
        //{
        //    return FirstNames[1];
        //}
        public static int GetYear(int age)
        {
            var date = DateTime.Now;
            return (date.Year - age);
        }
    }

}
