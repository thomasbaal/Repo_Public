using Undervisning_intro_til_objekter_ala_Javascript;
using static System.Console;

// Create a object in c#
// In JS we had to ":" after the keys, in c# its "="
var x = new {width = 50, height = 30}; 
Console.WriteLine(x);
// Dotting in works the same.
WriteLine($"The width is: {x.width} \nThe height is: {x.height}");

var y = new Box();
y.Width = 50;
y.Height = 30;

ReadLine(); 