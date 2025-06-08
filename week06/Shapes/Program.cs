using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();


        Square square = new Square("red", 6);


        Rectangle rectangle = new Rectangle("blue", 10, 5);

        Circle circle = new Circle("yellow", 3);

        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (Shape item in shapes)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        }

    }

}