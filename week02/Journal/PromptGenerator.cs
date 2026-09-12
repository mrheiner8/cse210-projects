// PromptGenerator.cs
using System;
using System.Collections.Generic;


// Create a class (custom data types) to use in Program
public class PromptGenerator
{
    // Create Member variables
    public List<string> _prompts = [];
    public PromptGenerator()
    {
        _prompts = new List<string> { "Who was the most interesting person I interacted with today", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was something unexpected that happened today?", "What one thing I did today that I would like do do again?" };
    }
    // Create custom method to 
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}    
// End PromptGenerator.cs