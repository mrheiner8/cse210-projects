// ChecklistGoal.cs
using System;

// Create a class (custom data types) to use in Program
public class ChecklistGoal : Goal
{
    // Member variables
    private int _bonus;
    private int _target;
    private int _amountCompleted;
   

    // Constructors
    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Getters and Setters
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    // Methods
    public override int RecordEvent()
    {
        
        if (IsComplete())
        {
            return 0;
        }
        else
        {
            _amountCompleted++;
        }


        if (_amountCompleted == _target)
        {
            return GetPoints() + GetBonus();
        }
        else
        {
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType().Name}~{GetName()}~{GetDescription()}~{GetPoints()}~{GetBonus()}~{GetTarget()}~{GetAmountCompleted()}";
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} --Currently Completed: {_amountCompleted} of {_target}";
    }
}
// End ChecklistGoal.cs