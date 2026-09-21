// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }

            Console.WriteLine("Press the Enter(return) key to continue, or type 'quit' to finish:");
            input = Console.ReadLine();
            Console.Clear();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(5);
        }
        Console.WriteLine("\nThank you, come again!");
    }
}
// End Program.cs