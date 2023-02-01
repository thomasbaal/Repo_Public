using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string Guid { get; set; }
        public Person(string firstName, string lastName, int birthYear, string guid)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
            Guid = guid;
        }
    }
}
