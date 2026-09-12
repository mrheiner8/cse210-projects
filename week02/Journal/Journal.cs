// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;
{
    
}


// Create a class (custom data types) to use in Program
public class Journal
{
    // Create Member variables
    public List<Entry> _entries = [];


    // Create custom method to format and display data stored in '-entries'
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry b in _entries)
        {
            b.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                
                outputFile.WriteLine(e.SaveEntry());
            }
        }
    }
    public void LoadFromFile(string file)
    {
        return;
    }
}
// End Journal.cs
