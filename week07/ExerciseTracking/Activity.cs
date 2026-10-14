// Activity.cs
using System;

// Create a class (custom data types) to use in Program
public abstract class Activity
{
    // Member variables
    private string _date = "";
    private double _minutes;

    // Constructors
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Getters and Setters
    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public void SetMinutes(double minutes)
    {
        _minutes = minutes;
    }

    // Methods
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public string GetSummary()
    {
        return ($"{GetDate()} {GetType()} ({GetMinutes():f2})- Distance {Distance():f2} Miles, Speed {Speed():f2} mph, Pace {Pace():f2} min per mile ");
    }
}
// End Activity.cs