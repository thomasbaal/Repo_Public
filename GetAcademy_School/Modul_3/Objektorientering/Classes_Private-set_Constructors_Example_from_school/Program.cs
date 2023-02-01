using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Private_set_Constructors_Example_from_school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Thomas");
            var person2 = new Person("Andrea");
            var person3 = new Person("Andrea", "Bravo");

            List<Person> listOfPeople = new List<Person>();

            listOfPeople.Add(person1);
            listOfPeople.Add(person2);
            listOfPeople.Add(person3);

            foreach (var item in listOfPeople)
            {
                //Console.WriteLine(item.Name + " " + item.Test);
                Console.WriteLine(item.Name + " " + item.Test);
            }


            var name1 = person1.Name; // denne propertien er tilgjengelig utenfor egen klasse!
            var name2 = person2.Name; // denne propertien er tilgjengelig utenfor egen klasse!
            var name3 = person3.Name + " " + person3.Test;
            //person1.Name = // her får man en kompilator feil som sier at dette ikke er tillatt

            Console.ReadLine();


        }
    }
}
