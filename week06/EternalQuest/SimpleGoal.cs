// SimpleGoal.cs
using System;

// Create a class (custom data types) to use in Program
public class SimpleGoal : Goal
{
    // Member variables
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // Getters and Setters
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }

    // Methods
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
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
// End SimpleGoal.cs