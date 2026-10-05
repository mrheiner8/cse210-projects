// ReflectingActivity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class ReflectingActivity : Activity
{
    // Member variables
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructors
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    // Methods
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:\n");

        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        //Console.Clear(); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(15);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string randomQuestion = _questions[index];

        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}
// End ReflectingActivity.cs