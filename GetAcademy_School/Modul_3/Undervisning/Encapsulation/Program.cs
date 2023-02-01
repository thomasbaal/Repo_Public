// Todo: Showing encapsulation basics.

using Encapsulation;

// Todo: crea a new class Rectangle03,

var Rectangles3 = new Rectangle03[]
{
    new Rectangle03(2, 2),
    new Rectangle03(3, 3),
    new Rectangle03(4, 4),
};



//Todo: Create a new class Rectangle02,

var rectangles2 = new Rectangle02[]
{



};
var totalArea2 = rectangles2.Sum(rect => rect.Area());
Console.WriteLine(totalArea2);



///////////////////////////////////////////////////////////////////////////
// Todo: Create new instance of Rectangle as an "Array"

var rectangles = new Rectangle[]
{
    new Rectangle(7, 3),
    new Rectangle(2, 11),
    new Rectangle(5, 6),
};


var totalArea = rectangles.Sum(r=>r.Area());
Console.WriteLine(totalArea);
Console.ReadLine();