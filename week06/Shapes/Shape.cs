// Shape.cs
using System;

// Create a class (custom data types) to use in Program
public class Shape
{
    // Member variables 
    private string _color = "";
    // Constructors
    public Shape(string color)
    {
        _color = color;
    }
    
    // Getters and Setters
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    // Methods
    public virtual double GetArea()
    {
        return 0;
    }
}
// End Shape.cs