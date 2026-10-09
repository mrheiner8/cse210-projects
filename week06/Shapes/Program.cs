// (Shapes) Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Blue", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Orange", 3.5, 4.6);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Green", 2.67);
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }

    }
}
// End Program.cs