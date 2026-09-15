// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;


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
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                
                outputFile.WriteLine(e.SaveEntry());
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string loadDate = parts[0];
            string loadPromptText = parts[1];
            string loadEntryText = parts[2];

            Entry myEntry = new Entry(loadDate, loadPromptText, loadEntryText);
            AddEntry(myEntry);
        }
    }
}
// End Journal.cs
