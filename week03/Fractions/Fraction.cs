// Fraction.cs
using System;


// Create a class (custom data types) to use in Program
public class Fraction
{
    // Member variables
    private int _top;
    private int _bottom;

    // Constructors

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
  
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }
    
    // SetTop(top : int)
    public int GetBottom()
    {
        return _bottom;
    }
    
    // SetBottom(bottom : int)
    

    // Methods
    /*
    GetFractionString() : string
    GetDecimalValue() : double
    */
}

// End Fraction.cs
