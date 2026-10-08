// (Shapes) Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square testSquare1 = new Square("Blue", 3);
        Console.WriteLine(testSquare1.DisplayArea());

        Rectangle testRectangle1 = new Rectangle("Orange", 3.5, 4.6);
        Console.WriteLine(testRectangle1.DisplayArea());

        Circle testCircle1 = new Circle("Green", 2.67);
        Console.WriteLine(testCircle1.DisplayArea());
    }
}
// End Program.cs