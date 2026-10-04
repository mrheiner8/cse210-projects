// BreathingActivity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class BreathingActivity : Activity
{
    // Constructors
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Methods
    public void Run()
    {
        // TODO: write this later
        DisplayStartingMessage();

        DisplayEndingMessage();
    }
}
// End BreathingActivity.cs
