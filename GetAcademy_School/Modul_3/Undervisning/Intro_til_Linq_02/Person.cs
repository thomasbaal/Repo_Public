using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_Linq_samples
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int PostalCode { get; set; }
        public int Age => (int)(DateTime.Now - BirthDay).TotalDays / 365; // typecasting (int) because Totaldays is data type double.

        public Person(int id, string firstName, string lastName, DateTime birthDay, int postalCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            PostalCode = postalCode;
        }
    }
}
