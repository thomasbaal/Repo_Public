using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startliste
{
    internal class Registration
    {
        public int StartNo { get; private set; }
        public string Name { get; private set; }
        public string Club { get; private set; }
        public string Nationality { get; private set; }
        public string Group { get; private set; }
        public string Class { get; private set; }


        public Registration(string csvLine)
        {
            /*"Start number","Name","Club","Nationality","Group","Class"
            "30066","Audun Levin","","NOR","25 km / Pulje 5 (seeding)","M35-39"
             */
           var arrLineParts = csvLine.Split(',');
            // add arrLineParts to "Registration properties"
            StartNo = Convert.ToInt32(arrLineParts[0]);
            Name = arrLineParts[1];
            Club = arrLineParts[2];
            Nationality = arrLineParts[3];
            Group = arrLineParts[4];
            Class = arrLineParts[5];
        }
        public Registration(int startNo, string name, string club, string nationality, string aGroup, string aClass)
        {
            StartNo = startNo;
            Name = name;
            Club = club;
            Nationality = nationality;
            Group = aGroup;
            Class = aClass;
        }


        
    }
}
