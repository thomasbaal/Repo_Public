using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01_Interface
{
    internal class Info
    {
        public int TextSpeed = 100;
        public int TextPauseSpeed = 1000;
        public List<string> InfoText { get; set; }
        public Info()
        {
            InfoText= new List<string>();   
        }

        public void DisplayInfo(int textSpeed)
        {
            WriteLine();
            WriteLine("-----Inheritance -----");

            TextSpeed = textSpeed;
           
            InfoText.Add("Interface starts with 'I'");
            InfoText.Add("Cannot use access modifiers inside an Interface");
            InfoText.Add("All members of an interface are < public  by default >");
            InfoText.Add("Interface doesn't allow fields");
            InfoText.Add("A class can have multiple Interfaces");
            InfoText.Add("A Interface provides specifications that a class(which implements it) Must follow.");
            InfoText.Add("A Interface help to provide < abstraction > to the code.");

            foreach (var item in InfoText)
            {
                var splitted = item.Split(' ');
                foreach (var character in splitted)
                {
                    Task.Delay(TextSpeed).Wait();
                    Write(character + " ");
                }
                Task.Delay(TextPauseSpeed).Wait();
                WriteLine();
            }

        }




    }
    

}
