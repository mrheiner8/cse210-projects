// Square.cs
using System;

// Create a class (custom data types) to use in Program
public class Square : Shape
{
    // Member variables
    private double _side;

    // Constructors
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    
    // Getters and Setters
    public double GetSide()
    {
        return _side;
    }

    public void SetSide(double side)
    {
        _side = side;
    }
    // Methods
    public override double GetArea()
    {
        double area = GetSide() * GetSide();
        return area;
    }

    public string DisplayArea()
    {
        return $"The area of the {GetColor()} Square is {GetArea():F2} square units.";
    }
}
// End Square.cs