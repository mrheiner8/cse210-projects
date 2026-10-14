// Swimming.cs
using System;

// Create a class (custom data types) to use in Program
public class Swimming : Activity
{
    // Member variables
    private int _laps;

    // Constructors
    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Getters and Setters
    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    // Methods
    public override double Distance()
    {
        double swimmingDistance = _laps * 50.0 / 1000 * 0.62;
        return swimmingDistance;
    }
    public override double Speed()
    {
        double swimmingSpeed = Distance() / GetMinutes() * 60;
        return swimmingSpeed;
    }
    public override double Pace()
    {
        double swimmingPace = 60 / Speed();
        return swimmingPace;
    }
}
// End Swimming.cs