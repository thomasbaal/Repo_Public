using Demo;

List<Shape> shapes = new List<Shape>();
shapes.Add(new Rectangle(2, 5, "Rectangle nr 1", "Red"));
shapes.Add(new Rectangle(12, 14, "Rectangle nr 2", "Yellow"));
shapes.Add(new Circle(5, "Circle 1", "Blue"));


foreach (var shape in shapes)
{
    if (shape is Rectangle)
    {
        Console.WriteLine("Rectangles --------------");
        Console.WriteLine($"Area :{shape.CalculateArea()}");
        Console.WriteLine($"{shape.GetInfo()}");
    }
    else
    {
        Console.WriteLine("Circles --------------");
        Console.WriteLine($"Area :{shape.CalculateArea()}");
        Console.WriteLine($"{shape.GetInfo()}");
    }
}

Console.ReadLine();