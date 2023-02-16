using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Animal
    {
        private string _name;
        private string _color;
        private decimal _weight;

        public Animal(string name, string color, decimal weight)
        {
            _name = name;
            _color = color;
            _weight = weight;
        }

        public virtual string MakeSound()
        {
            return this._name + " " + "making a sound ";
        }

        public abstract void Something();

        public virtual string Eat()
        {
            return $"{this._name}";
        }

        public virtual string GetNameOfObject()
        {
            return $"{this.ToString()}";
        }


    }
}
