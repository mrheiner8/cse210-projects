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
        _isComplete = false;
    }

    // Methods
    public override int RecordEvent()
    {
        if (_isComplete == true)
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
// End SimpleGoal.cs