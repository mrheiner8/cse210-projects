// Rectangle.cs
using System;

// Create a class (custom data types) to use in Program
public class Rectangle : Shape
{
    // Member variables
    private double _length;
    private double _width;

    // Constructors
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Getters and Setters
    public double GetLength()
    {
        return _length;
    }

    public void SetLength( double length)
    {
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }
    // Methods
    public override double GetArea()
    {
        double area = GetLength() * GetWidth();
        return area;
    }
}
// End Rectangle.cs