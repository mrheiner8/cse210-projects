// Circle.cs
using System;

// Create a class (custom data types) to use in Program
public class Circle : Shape
{
    // Member variables
    private double _radius;

    // Constructors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Getters and Setters
    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    // Methods
    public override double GetArea()
    {
        double area = Math.PI * GetRadius() * GetRadius();
        return area;
    }
    
    public string DisplayArea()
    {
        return $"The area of the {GetColor()} Circle is {GetArea():F2} square units.";
    }
}
// End Circle.cs