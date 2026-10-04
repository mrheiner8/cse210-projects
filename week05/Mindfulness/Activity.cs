// Activity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Activity
{
    // Member variables
    protected string _name = "";
    protected string _description = "";
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

        //Console.Clear();

        Console.Write("Get Ready…\n");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!\n");

        ShowSpinner(5);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);

        //Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = ["|", "/", "-", "\\"];

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int spins = 0;

        while (DateTime.Now < endTime)
        {
            string spinner = spinnerStrings[spins];
            Console.Write(spinner);
            Thread.Sleep(500);
            Console.Write("\b \b");

            spins++;
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