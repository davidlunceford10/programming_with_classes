using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("orange", 5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("black", 7, 6);
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("blue", 5);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> Shapes = new List<Shape>();
        Shapes.Add(square);
        Shapes.Add(circle);
        Shapes.Add(rectangle);



        foreach (Shape shape in Shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}