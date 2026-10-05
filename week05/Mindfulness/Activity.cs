// Activity.cs
using System;
using System.Collections.Generic;
using System.Threading;

// Create a class (custom data types) to use in Program
public class Activity
{
    // Member variables
    private string _name = "";
    private string _description = "";
    private int _duration;

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
        Console.WriteLine($"Welcome to the {_name} Activity\n\n{_description}");

        Console.WriteLine("\nHow long, in seconds, would you like your session?");
        string durationInput = Console.ReadLine();
        SetDuration(int.Parse(durationInput));

        Console.Clear();

        Console.Write("Get Ready…\n");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!\n");

        ShowSpinner(5);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);

        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        // Create a list<string> of characters needed for the spinner
        List<string> spinnerStrings = ["|", "/", "-", "\\"];

        // Get current time from DateTime. Now for the start time and add seconds to get the end time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        // Set to 0 to use for index reset.
        int spins = 0;

        // Create a while loop to loop through each index in the list sequentially 
        while (DateTime.Now < endTime)
        {
            // Set local variable to get one index at a time
            string spinner = spinnerStrings[spins];
            // Write spin spinnerStrings character, pause for half a second, erase that character, repeat with the next index
            Console.Write(spinner);
            Thread.Sleep(500);
            Console.Write("\b \b");
            spins++;

            // When the count goes beyond the last index, reset to the starting index
            if (spins >= spinnerStrings.Count)
            {
                spins = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int countDown = seconds; countDown > 0; countDown--)
        {
            Console.Write(countDown);
            Thread.Sleep(1000);
            string countDownString = countDown.ToString();
            string backSpace = new string('\b', countDownString.Length);
            string emptySpace = new string(' ', countDownString.Length);
            Console.Write($"{backSpace}{emptySpace}{backSpace}");
        }
    }
}
// End Activity.cs