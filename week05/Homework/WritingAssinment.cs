// WritingAssignment.cs
using System;

// Create a class (custom data types) to use in Program
public class WritingAssignment : Assignment
{
    // Member variables
    private string _title = "";

    // Constructors
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
// End WritingAssignment.cs