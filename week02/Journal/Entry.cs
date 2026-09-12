// Entry.cs
using System;

// Create a class (custom data types) to use in Program
public class Entry
{
    // Create Member variables
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Create custom method to format and display data stored in 'Entry'
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}\n{_entryText}");
    }

    public string SaveEntry()
    {
        return $"{_date}~{_promptText}~{_entryText}";
    }
}
// End Entry.cs