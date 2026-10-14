// Cycling.cs
using System;

// Create a class (custom data types) to use in Program
public class Cycling : Activity
{
    // Member variables
    private double _speed;

    // Constructors
    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Getters and Setters
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    // Methods
    public override double Distance()
    {
        double cyclingDistance = Speed() * GetMinutes() / 60;
        return cyclingDistance;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        double cyclingPace = 60 / Speed();
        return cyclingPace;
    }
}
// End Cycling.cs