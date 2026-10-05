// ListingActivity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class ListingActivity : Activity
{
    // Member variables
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

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userResponses = GetListFromUser();

        Console.WriteLine($"\nYou listed {userResponses.Count} items!");

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- ");
    }
    public List<string> GetListFromUser()
    {
        /*
        Known limitations: 
        1. pressing enter without typing anything else will create a blank line will count in the final count 
        2. If the timer times out while the user is in the middle of an unsaved line the line will be lost.
        3. Because ReadKey is blocking, the timer only ends after a keystroke. 
        */
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        string responseLine = "";
        List<string> responses = new();

        while (DateTime.Now < endTime)
        {
            string keyStroke = Console.ReadKey().KeyChar.ToString();

            if (keyStroke == "\r")
            {
                Console.WriteLine("");
                responses.Add(responseLine);
                responseLine = "";
            }
            else
            {
                responseLine += keyStroke;
            }
        }
        return responses;
    }
}
// End ListingActivity.cs
