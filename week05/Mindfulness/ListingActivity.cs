// ListingActivity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructors
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    
    // Getters and Setters
    public int GetCount() //Remove if not needed
    {
        return _count;
    }
    public void SetCount(int count)//Remove if not needed
    {
        _count = count;
    }

    // Methods
    public void Run()
    {
        // TODO: write this later
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            /*
            "> 'User input' into GetListFromUser()"(repeated for the duration)
            */
        }
        
        Console.WriteLine($"You listed {GetCount}items!");


        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
    }
    public List<string> GetListFromUser()
    {
        return [];// placeholder so it compiles
    }
}
// End ListingActivity.cs
