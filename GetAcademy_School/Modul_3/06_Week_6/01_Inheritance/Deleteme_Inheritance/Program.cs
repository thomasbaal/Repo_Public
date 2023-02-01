using Deleteme_Inheritance;
using static System.Console;


Cat cat1 = new Cat();
cat1.Name = "Tom";
cat1.DisplayName();
//cat1.Eat(); // cat1 created here cant see parent protected method.
// You must create this inside the class , of the the derived class.


Dog dog1 = new Dog();

// Overriding base class Eat() Method
dog1.WhatDoIEat();

// overide base class Method and calling base class Method at the ame time.
WriteLine("---- override and base call -----");
cat1.WhatDoIEat();
