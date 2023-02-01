using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minioppgave_Nyrer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a List of Kidneys.
            List<Kidneys_Class> listOfKidneys = new List<Kidneys_Class>();

            // Create the Kidneys.
            Kidneys_Class kidney1 = new Kidneys_Class("Type-A", 99, 1, "Truls");
            Kidneys_Class kidney2 = new Kidneys_Class("Type-B", 199, 2, "Henrik");
            Kidneys_Class kidney3 = new Kidneys_Class("Type-AB", 299, 0, "Rasmus");
            Kidneys_Class kidney4 = new Kidneys_Class("Type-O", 399, 3, "Labbetuss");
            //Kidneys_Class kidney5 = new Kidneys_Class("", , , , 1);

            listOfKidneys.Add(kidney1);
            listOfKidneys.Add(kidney2);
            listOfKidneys.Add(kidney3);
            listOfKidneys.Add(kidney4);

            Console.WriteLine("What sort of kidney would you like.");


           


            Console.ReadLine();




        }
    }
}