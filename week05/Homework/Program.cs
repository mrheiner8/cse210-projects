// (Homework)Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment testAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(testAssignment.GetSummary());

        Console.WriteLine();
        MathAssignment testMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(testMathAssignment.GetSummary());
        Console.WriteLine(testMathAssignment.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment testWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(testWritingAssignment.GetSummary());
        Console.WriteLine(testWritingAssignment.GetWritingInformation());
    }
}
// End (Homework)Program.cs