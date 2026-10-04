// (Mindfulness) Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");


        Activity a1 = new Activity("Rooting", "name one thing that you can see, one thing you can hear, one thing you can touch, and one thing you can smell or taste right now");

        a1.DisplayStartingMessage();
        a1.DisplayEndingMessage();
    }
}
// End (Mindfulness) Program.cs