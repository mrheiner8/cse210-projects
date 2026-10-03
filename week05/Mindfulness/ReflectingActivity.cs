// ReflectingActivity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class ReflectingActivity : Activity
{
    // Member variables
    private List<string> _prompts = [];
    private List<string> _questions = [];

    // Constructors
    public ReflectingActivity() : base("Reflecting Activity", "Reflecting Activity description")
    {
    }

    // Getters and Setters (Remove if not needed)

    // Methods
    public void Run()
    {
        // TODO: write this later
    }
    public string GetRandomPrompt()
    {
        return "";// placeholder so it compiles
    }
    public string GetRandomQuestion()
    {
        return "";// placeholder so it compiles
    }
    public void DisplayPrompt()
    {
        // TODO: write this later
    }
    public void DisplayQuestions()
    {
        // TODO: write this later
    }
}
// End ReflectingActivity.cs