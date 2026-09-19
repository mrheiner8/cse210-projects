// Reference.cs
using System;


// Create a class (custom data types) to use in Program
public class Reference
{
    // Member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }


    // Getters and Setters
    public string GetDisplayText()
    {
        return "";
    }
}
// End Reference.cs