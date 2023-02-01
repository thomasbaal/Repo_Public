using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_Deserialize_with_sytem_text_json
{
    public class JsonComplexObject_Paste_Special
    {
        // paste special will make arrays of [] from json, you can change this to "Lists" if needed..
        
        // paste special will name the whole json object as Rootobject as it is not getting the name from enywhere.
                        // change this to something meaningfull for the json data. (this case we use Company).
        public class Company
        {
            public string id { get; set; }
            public string name { get; set; }
            public Cofounder[] cofounders { get; set; }
            public Employee[] employees { get; set; }
        }

        public class Cofounder
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Employee
        {
            public string id { get; set; }
            public string fullName { get; set; }
            public int anualSalary { get; set; }
            public Position position { get; set; }
            public Benefit[] benefits { get; set; }
        }

        public class Position
        {
            public string id { get; set; }
            public string description { get; set; }
        }

        public class Benefit
        {
            public string id { get; set; }
            public int additional { get; set; }
            public string description { get; set; }
        }



    }
}
