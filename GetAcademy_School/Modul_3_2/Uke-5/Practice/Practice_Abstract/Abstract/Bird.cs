using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Bird : Animal
    {
        private string _sound;
        private bool _isFull;

        public Bird(string sound, string name, string color, decimal weight, bool isFull) 
            : base(name, color, weight)
        {
            _sound = sound;
        }

        public override void Something()
        {
            Console.WriteLine($"Bird have to do this, because its calling a abstract method !");
            Console.WriteLine("-----------------------");
        }

        public override string MakeSound()
        {
            return $"{base.MakeSound()}\n The bird goes {_sound}";
        }

        public override string Eat()
        {
            if (!_isFull) return $"{base.Eat()} is eating !";
            return $"{base.Eat()} is Not! eating !";
        }
    }
}
