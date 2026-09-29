// WritingAssignment.cs
using System;

// Create a class (custom data types) to use in Program
public class WritingAssignment : Assignment
{
    // Member variables
    private string _title = "";
   
    // Constructors
    public WritingAssignment(string studentName, string topic, string title) : base 
    {
        _title = title;
    }

    // Getters and Setters
    public string GetWritingInformation()
    {
        return $"{_title}";
    }

    // Methods
}
// End WritingAssignment.cs