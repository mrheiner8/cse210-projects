// (Homework)Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        List<Assignment> assignments = new List<Assignment>();

        Assignment firstAssignment = new Assignment("Samuel Bennett", "Multiplication");
        assignments.Add(firstAssignment);

        Console.WriteLine(firstAssignment.GetSummary());

    }
}
// End (Homework)Program.cs