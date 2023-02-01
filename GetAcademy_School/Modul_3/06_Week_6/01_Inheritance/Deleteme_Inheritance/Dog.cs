using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Deleteme_Inheritance
{
    internal class Dog : Animal
    {
        public string FoodIEat = "DogFood";

        public void CreateSomeDogs()
        {
            Dog dog1 = new Dog();
            dog1.Eat();
        }
        public override void WhatDoIEat()
        {
            WriteLine("My favorite food is {0}", FoodIEat);
            
        }
    }
}
