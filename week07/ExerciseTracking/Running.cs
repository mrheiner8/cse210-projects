// Running.cs
using System;

// Create a class (custom data types) to use in Program
public class Running : Activity
{
    // Member variables
    private double _distance;

    // Constructors
    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Getters and Setters
    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    // Methods
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        double runningSpeed = Distance() / GetMinutes() * 60;
        return runningSpeed;
    }
    public override double Pace()
    {
        double runningPace = 60 / Speed();
        return runningPace;
    }
}
// End Running.cs