using Encapsulation;
using static System.Console;



var rectangles = new Rectangle[]
{
    new Rectangle(2, 3),
    new Rectangle(5, 3),
    new Rectangle(7, 4),

};

var volumes = new Volume[]
{
    new Volume(2, 2, 2),
    new Volume(3, 4, 5),
};

var totalVolume = volumes.Sum(v => v.TotalVolume());
WriteLine(totalVolume);


var areaOfAllRectangles = rectangles.Sum(r => r.SumArea());
WriteLine(areaOfAllRectangles);


WriteLine("--- Volume 2 -------");
var myVolume = new Volume2(5, 6, 7);
WriteLine(myVolume.Volume);

var volumes2 = new Rectangle[] {

    new Rectangle(2, 3),
    new Rectangle(1, 5),
    new Rectangle(3, 6),


};



WriteLine();
ReadLine();