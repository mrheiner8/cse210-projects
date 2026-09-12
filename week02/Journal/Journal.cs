// Journal.cs
using System;
using System.Collections.Generic;


// Create a class (custom data types) to use in Program
public class Journal
{
    // Create Member variables
    public List<Entry> _entries = [];


    // Create custom method to format and display data stored in '-entries'
    public void AddEntry(Entry newEntry)
    {
        return;
    }
    public void DisplayAll()
    {
        Console.WriteLine($"{_entries}");
        
        foreach (Entry b in _entries)
        {
            
        }
    }

    public void SaveToFile(string file)
    {
        return;
    }
    public void LoadFromFile(string file)
    {
        return;
    }
}
// End Journal.cs
