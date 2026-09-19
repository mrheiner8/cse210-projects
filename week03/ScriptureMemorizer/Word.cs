// Word.cs
using System;


// Create a class (custom data types) to use in Program
public class Word
{
    // Member variables
    private string _text;
    private bool _isHidden;

    // Constructors

    public Word(string text)
    {
        _text = text;
    }

    // Getters and Setters
    public string GetDisplayText()
    {
        return _text;
    }
    // Methods

    public void Hide()
    {
        return ;
    }

    public void Show()
    {
        return;
    }

    /* commented out for now so that is doesn't break the code
    public bool IsHidden()
    {
        return ;
    }
    */
}
// End Word.cs