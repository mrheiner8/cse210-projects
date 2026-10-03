// Activity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Activity
{
    // Member variables
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    // Constructors
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Getters and Setters
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    
    // Methods
    public void DisplayStartingMessage()
    {
        // TODO: write this later
    }
    public void DisplayEndingMessage()
    {
        // TODO: write this later
    }
    public void ShowSpinner(int seconds)
    {
        // TODO: write this later
    }
    public void ShowCountDown(int seconds)
    {
        // TODO: write this later
    }
}
// End Activity.cs