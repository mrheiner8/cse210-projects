// Activity.cs
using System;

// Create a class (custom data types) to use in Program
public abstract class Activity
{
    // Member variables
    private string _date = "";
    private double _timeLength;

    // Constructors
    public Activity(string date, double timeLength)
    {
        _date = date;
        _timeLength = timeLength;
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

    public double GetTimeLength()
    {
        return _timeLength;
    }

    public void SetTimeLength(double timeLength)
    {
        _timeLength = timeLength;
    }


    // Methods
    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public string GetSummary()
    {
        return ($"{GetDate()} {GetType()} ({GetTimeLength()})- Distance {Distance()} Miles, Speed {Speed()} mph, Pace {Pace()} min per mile ");
    }
}
// End Activity.cs