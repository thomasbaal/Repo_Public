using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleteme
{
    public class Employee
    {
        private string FirstName;
        private string LastName;
        private string Profession;
        public bool IsManager { get; private set; }

        public Employee(string fName, string lName, string profession = "Undefined")
        {
            FirstName = fName;
            LastName = lName;
            Profession = "Unknown";
        }
    }
}
