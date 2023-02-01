using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleteme
{
    public class DataSource
    {

        public DataSource()
        {

        }
        //Todo: Change from foreach to Linq lambda
        public void GenerateRooms(Hotel hotel)
        {
            for (int floors = 1; floors < 10; floors++)
            {
                for (int rooms = 1; rooms < 10; rooms++)
                {
                    int test = int.Parse(floors.ToString() + 0.ToString() + rooms.ToString());
                    Random r = new Random();
                    hotel.Li_HotelRooms.Add(new Room(Convert.ToInt32(floors.ToString() + 0.ToString() + rooms.ToString()), 2, GenerateTrueOrFalse(r)));

                }
            }
        }

        private bool GenerateTrueOrFalse(Random r)
        {
            bool isAvailable = false;
            var random = r.Next(2);
            if (random == 0) { isAvailable = false; }
            else { isAvailable = true; }
            //WriteLine("isavaialable" + isAvailable);
            return isAvailable;
        }

        public void GenerateEmployees(Hotel hotel)
        {
            // må kanskje bytte hele greia til Streamreader ?!

            var filePath_LastNames = @"E:\01_Coding\021__C#_Testing_and_trying_things\Deleteme\TestFiles\LastNames.csv";

            string[] csv_Line = File.ReadAllLines(filePath_LastNames);
            string[] separatedWords;
            List<string> fixedCsv = new List<string>();
            //int findIndexOfSpace = 0; // funker ikke på space.
            //char[] seperators = { '.', '\t' };
            List<string> fixedSeparatedWords = new List<string>();
            foreach (var line in csv_Line)
            {
                separatedWords = line.Split('\t');
                fixedSeparatedWords.Add(separatedWords[0]);

            }
            WriteLine("----- Lastnames -----");
            foreach (var word in fixedSeparatedWords)
            {
                WriteLine(word);
            }


        }




    }
}
