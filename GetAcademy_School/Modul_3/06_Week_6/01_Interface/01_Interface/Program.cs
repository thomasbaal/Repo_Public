using _01_Interface;
using static System.Console;

// Inheritance
/*
 In C#, an interface is similar to abstract class. However, unlike abstract classes
 all methods of an interface are fully abstract (method without body).
*/

//Rectangle rectangle = new Rectangle();
//rectangle.CalculateArea(2, 4);

Rectangle[] rectangles = new Rectangle[]
{
    new Rectangle(3, 5),
    new Rectangle(30, 50),
    new Rectangle(13, 15),
    new Rectangle(23, 25),
};


Info info = new Info();
info.DisplayInfo(100);





ReadLine();