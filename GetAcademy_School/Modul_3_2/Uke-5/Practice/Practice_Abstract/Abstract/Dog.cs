using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Dog : Animal
    {
       
        private string _sound;
        private bool _isFull;


        public Dog(string sound, string name, string color, decimal weight, bool isFull) 
            :base(name,color,weight)
        {
            _sound = sound;
            _isFull = isFull;

        }
        // kall på en virtual kan overskrive arvede metoder, men må ikke
        public override string MakeSound()
        {
            return $"{base.MakeSound()}\n The dog goes {_sound}";
        }

        // kall på en abstract Metode Må! overrides, deaktiver å man får feil.
        public override void Something()
        {
            Console.WriteLine($"Dog have to do this, because its calling a abstract method !");
            Console.WriteLine("-----------------------");
        }

        public override string Eat()
        {
            if (!_isFull) return $"{base.Eat()} is eating !";
            return $"{base.Eat()} is Not! eating !";
        }

        public void Whatever()
        {
            Console.WriteLine($"{this.GetType()}");
            
        }

    }
}
