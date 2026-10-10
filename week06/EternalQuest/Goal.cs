// Goal.cs
using System;

// Create a class (custom data types) to use in Program
public abstract class Goal
{
    // Member variables
    private string _shortName = "";
    private string _description = "";
    private int _points;

    // Constructors
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getters and Setters
    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    // Methods
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string check = "";
        if (IsComplete() == false)
        {
            check = " ";
        }
        else
        {
            check = "X";
        }
        return ($"[{check}]  {GetName()} ({GetDescription()})");
    }
    public abstract string GetStringRepresentation();
}
// End Goal.cs