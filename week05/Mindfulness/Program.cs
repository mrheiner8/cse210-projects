// (Mindfulness) Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice = "0";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit\nSelect a choice from the menu(1, 2, 3, or 4): ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

            else if (choice == "4")
            {
                //Console.Clear();
                Console.WriteLine("\nThank you have a nice day!");
            }

            else
            {
                Console.WriteLine("\nI'm sorry that was an invalid response. Please select 1, 2, 3, or 4.\n");
            }
        }
    }
}
// End (Mindfulness) Program.cs