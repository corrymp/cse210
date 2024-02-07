using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new()
        {
            new Square("Red",3),
            new Rectangle("Green",2,3),
            new Circle("Blue",2)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} | {shape.GetArea()}");
        }
    }
}