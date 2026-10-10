// EternalGoal.cs
using System;

// Create a class (custom data types) to use in Program
public class EternalGoal : Goal
{
    // Member variables

    // Constructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // Getters and Setters

    // Methods
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}
// End EternalGoal.cs