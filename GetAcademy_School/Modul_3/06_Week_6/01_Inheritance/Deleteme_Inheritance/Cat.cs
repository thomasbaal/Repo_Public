using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Deleteme_Inheritance
{
    internal class Cat : Animal
    {
        public string FoodIEat = "CatFood";
            public void CreateCat()
        {
            Cat cat2= new Cat();
            cat2.Eat(); // object can see parent if created inside the class of the derived class.
        }
        public override void WhatDoIEat()
        {
            WriteLine("My favorite food is {0}", FoodIEat);
            base.WhatDoIEat();
        }
    }
}
