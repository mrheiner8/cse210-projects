// Program.cs
using System;
/* Program limitations worth noting.
1. Load will always erase any data stored in _entries
    Fix: Either prevent load if there is data found in _entries or ask if the user wants to safe first.
2. Save will always overwrite data saved in a file if that file already exist
    Fix: Ask the user if they would like to append to to file or overwrite the file 
3. Quit will quit no mater what erasing all data saved in _entries.
    Fix: Prompt user to save before quitting.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Console.WriteLine("\nWelcome to the Journal Program!");

        Journal myJournal = new Journal();
        PromptGenerator myPromptGenerator = new PromptGenerator();

        // Show a menu with options: write, display, save, load, quit
        string choice = "0";
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would You like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Get the date and time
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                string promptText = myPromptGenerator.GetRandomPrompt();

                Console.WriteLine("\nYou chose #1. Write!\n");
                // Writing an entry: get a random prompt, ask the user to respond, record date + prompt + response
                Console.WriteLine($"{promptText}");

                string entryText = Console.ReadLine();


                Entry myEntry = new Entry(date, promptText, entryText);
                myJournal.AddEntry(myEntry);

            }

            else if (choice == "2")
            {
                Console.WriteLine("\nYou chose #2 Display!\n");
                // Display: loop through all entries and show each one
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.WriteLine("\nYou chose #3 Save!\n");
                // Save: ask for a filename, write all entries to that file(using a separator character like |, since it's a plain text file, not real CSV)
                Console.WriteLine("What would you like the file name to be?");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);

                Console.WriteLine($"\nSaving to '{file}'");
            }

            else if (choice == "4")
            {
                Console.WriteLine("\nYou chose #4 Load!\n");
                // Load: ask for a filename, read it back in, and replace the current list of entries
                Console.WriteLine("What is the name of the file name you would like to load?");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);

                Console.WriteLine($"\nLoading '{file}'");
                myJournal.DisplayAll();
            }

            else if (choice == "5")
            {
                Console.WriteLine("\nThank you have a nice day!");
            }

            else
            {
                Console.WriteLine("\nI'm sorry that was an invalid response. Please select 1, 2, 3, 4, or 5\n");
            }
        }
    }
}
// End Program.cs