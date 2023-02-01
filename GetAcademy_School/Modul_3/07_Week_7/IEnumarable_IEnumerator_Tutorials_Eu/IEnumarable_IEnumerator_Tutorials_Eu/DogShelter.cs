using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IEnumarable_IEnumerator_Tutorials_Eu
{
    internal class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> LiDogs { get; set; }

        public DogShelter()
        {
            LiDogs = new List<Dog>(){
                new Dog("Pablo", false),
                new Dog("Marco", true),
                new Dog("Zelda", false),
                new Dog("Cindy", false),
            };
        }


        public IEnumerator<Dog> GetEnumerator()
        {
            return LiDogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        


    }
}
