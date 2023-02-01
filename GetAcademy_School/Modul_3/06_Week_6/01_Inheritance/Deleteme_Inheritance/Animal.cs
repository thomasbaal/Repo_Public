using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Deleteme_Inheritance
{
    internal class Animal
    {
        public string Name { get; set; }
        protected string TypeOfAnimal = "Animal";

        public Animal()
        {
            
        }
        public void DisplayName()
        {
            WriteLine("My name is {0} and i'm a {1}", Name, TypeOfAnimal);
        }

        protected void Eat()
        {
            WriteLine("I can Eat !");
        }
        public void TestProtectedMethod()
        {

        }
        public virtual void WhatDoIEat()
        {
            WriteLine("I eat everything !.");
        }
    }
}
