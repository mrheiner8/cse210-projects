// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string input = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.WriteLine ($"{scripture.GetDisplayText()}"); //($"\n{reference.GetDisplayText()} \n{scripture.GetDisplayText()}\n");

        while (input != "quit" && scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine("Press the Enter(return) key to continue, or type 'quit' to finish:");
            input = Console.ReadLine();


        }
        Console.WriteLine("\nThank you, come again!");
    }
}
// End Program.cs