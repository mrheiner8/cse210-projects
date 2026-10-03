// ListingActivity.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts = [];

    // Constructors
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    
    // Getters and Setters
    public int GetCount() //Remove if not needed
    {
        return _count;
    }
    public void SetCount(int count)//Remove if not needed
    {
        _count = count;
    }

    // Methods
    public void Run()
    {
        // TODO: write this later
    }
    public string GetRandomPrompt()
    {
        return "";// placeholder so it compiles
    }
    public List<string> GetListFromUser()
    {
        return [];// placeholder so it compiles
    }
}
// End ListingActivity.cs
