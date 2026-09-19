// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string input = "";
        Reference reference = new Reference("Amos", 1, 5, 7);
        Scripture scripture = new Scripture(reference, "once upon a time...");

        Console.WriteLine($"\n{reference.GetDisplayText()} \n\"once upon a time...\"\n");

        while (input != "quit" && scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine("Press the Enter(return) key to continue, or type 'quit' to finish:");
            input = Console.ReadLine();


        }
        Console.WriteLine("\nThank you, come again!");
    }
}
// End Program.cs