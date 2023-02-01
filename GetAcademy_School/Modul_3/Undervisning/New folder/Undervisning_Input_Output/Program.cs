using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning_Input_Output
{
    internal class Program
    {
        /*
                Input og Output skjerm/tastatur
                Input og Output fil
                
                Encoding
                Using - for dispose fil-resurser
                List<string> - ToArray
                string.contains
                string.Length
                string.substring

                Random
                
             */
        // File.ReadAllLines() - Opens a text file, reads all lines of the file into a string array, and then closes the file.
        // File.ReadAllText() - Opens a text file, reads all the text in the file into a string, and then closes the file.
        // File.WriteAllText() - Creates a new file, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten.

        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            // List
            var filePath4 = @"E:\01_Coding\04_Get_Academy_School\Modul_3\Undervisning\New folder\Undervisning_Input_Output\fruits.txt";
            MyListFromFile(filePath4);


            ///////////////////////////////////////////////////////////////////////////////////////
            var filePath = @"E:\01_Coding\04_Get_Academy_School\Modul_3\Undervisning\New folder\Undervisning_Input_Output\names.txt";
            var filePath2 = @"E:\01_Coding\04_Get_Academy_School\Modul_3\Undervisning\New folder\Undervisning_Input_Output\names2.txt";
            var filePath3 = @"E:\01_Coding\04_Get_Academy_School\Modul_3\Undervisning\New folder\Undervisning_Input_Output\names3.txt";
            // Import file and set to a variable.
            var imp_names = File.ReadAllText(filePath);

            // duplicating the text inside the text file.
            imp_names = imp_names + imp_names;
            
            // read text file as an array
            var imp_names2 = File.ReadAllLines(filePath);

            File.WriteAllText(filePath2, imp_names);

            foreach (var ele in imp_names2)
            {
                //Console.WriteLine(ele);
            }

            var allLines = File.ReadAllLines(filePath2);
            for (var index = 0; index < allLines.Length; index++)
            {
                var lines = allLines[index];
                var lineNumber = (index + 1).ToString().PadLeft(5, '0');
                Console.WriteLine(lineNumber + " " + lines);

            }

            Console.WriteLine("Do while -------------------------");
            using (var streamReader = File.OpenText(filePath3))
            {
                string line = null;
                int lineNo = 1;

                do
                {
                    Console.WriteLine(lineNo + ": " + line);
                    lineNo++;

                } while (line != null);
            } 


            //Console.WriteLine(imp_names);
            Console.ReadLine();



        }

        private static void MyListFromFile(string filePath4)
        {
            var myList = new List<string>();
            using (var streamReader = File.OpenText(filePath4))
            {
                string line = null;

                do
                {
                    line = streamReader.ReadLine();
                    if (line != null)
                    {
                        myList.Add(line);
                    }
                } while (line != null);
            }
        }
    }
}
