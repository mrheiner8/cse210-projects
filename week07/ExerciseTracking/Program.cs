// (ExerciseTracking) Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running("February 22, 2026", 30, 3);
        activities.Add(running1);

        Cycling cycling1 = new Cycling("August 22, 2026", 30, 15);
        activities.Add(cycling1);

        Swimming swimming1 = new Swimming("July 7, 2026", 20, 10);
        activities.Add(swimming1);

        foreach (Activity log in activities)
        {
            Console.WriteLine($"\n{log.GetSummary()}");
        }
        Console.WriteLine();
    }
}
// End (ExerciseTracking) Program.cs