// Assignment.cs
using System;

// Create a class (custom data types) to use in Program
public class Assignment
{
    // Member variables
    protected string _studentName = "";
    protected string _topic = "";

    // Constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Methods
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
// End Assignment.cs