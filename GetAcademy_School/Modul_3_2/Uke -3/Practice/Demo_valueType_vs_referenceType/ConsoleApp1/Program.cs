using System;
using System.Collections.Generic;
using BrownfieldLibrary;
namespace Demonstration
{

    namespace Refactored
    {
        class Program
        {
            static void Main(string[] args)
            {
                double totalHours;
                List<TimeSheetEntry> timeSheetEntries = CreateTimeSheet();
                Console.ReadLine();
            }


            private static List<TimeSheetEntry> CreateTimeSheet()
            {
                List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();

                string enterMoreTimeSheets = "";
                do
                {
                    Console.Write("Enter what you did: ");
                    string workDone = Console.ReadLine();
                    Console.Write("How long did you do it for: ");
                    var rawtimeWorked = Console.ReadLine();

                    double hoursWorked;
                    while (double.TryParse(rawtimeWorked, out hoursWorked) == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid number given");
                        Console.Write("How long did you do it for: ");
                        rawtimeWorked = Console.ReadLine();
                    }

                    TimeSheetEntry timeSheet = new TimeSheetEntry();
                    timeSheet.HoursWorked = hoursWorked;
                    timeSheet.WorkDone = workDone;
                    timeSheetEntries.Add(timeSheet);
                    Console.Write("Do you want to enter more time (yes/no): ");
                    enterMoreTimeSheets = Console.ReadLine();

                } while (enterMoreTimeSheets.ToLower() == "yes");
                return timeSheetEntries;
            }

            private static void BillCustomer(List<TimeSheetEntry>  timeSheetEntries, string companyName, decimal hourlyRate)
            {
                double totalHours = TimeSheetProcessor.GetHoursWorkedForCompany(timeSheetEntries, companyName);

                Console.WriteLine("Simulating Sending email to Acme");
                Console.WriteLine("Your bill is $" + (decimal)totalHours * hourlyRate + " for the hours worked.");
            }

            private static void PrintTotal(List<TimeSheetEntry> timeSheets)
            {
                double total = 0;

                for (var i = 0; i < timeSheets.Count; i++)
                {
                    total += timeSheets[i].HoursWorked;
                }
                if (total > 40)
                {
                    Console.WriteLine("You will get paid $" + (((total - 40) * 15) + (40 * 10)) + " for your work.");
                }
                else
                {
                    Console.WriteLine("You will get paid $" + total * 10 + " for your time.");
                }
                Console.WriteLine();
                Console.Write("Press any key to exit application...");
                Console.ReadKey();
            }



        }


    }
}



// decimal.TryParse(rawTimeWorked, out hoursWorked) == false