// MathAssignment.cs
using System;

// Create a class (custom data types) to use in Program
public class MathAssignment : Assignment
{
    // Member variables
    private string _textbookSection = "";
    private string _problems = "";

    // Constructors
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base 
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Getters and Setters
    public string GetHomeworkList()
    {
        return $"{_textbookSection} {_problems}";
    }

    // Methods
}
// End MathAssignment.cs