using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrownfieldLibrary
{
    public static class TimeSheetProcessor
    {
        public static double GetHoursWorkedForCompany(List<TimeSheetEntry> timeSheets, string company)
        {
            double output = 0;
            for (var i = 0; i < timeSheets.Count; i++)
            {
                if (timeSheets[i].WorkDone.ToLower().Contains("acme"))
                {
                    output += timeSheets[i].HoursWorked;
                }
            }
            return output;
        }
      
    }
}
