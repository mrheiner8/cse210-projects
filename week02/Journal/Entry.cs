// Entry.cs
using System;

// Create a class (custom data types) to use in Program
public class Entry
{
    // Create Member variables
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";


    // Create custom method to format and display data stored in 'Job'
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}
// End Entry.cs