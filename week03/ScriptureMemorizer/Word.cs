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
    public string GetDisplayText() //comeback to this whe reference is done
    {
        if (_isHidden == false)//(!_isHidden)
        {
            return _text;
        }
        else
        {
            string hiddenText = new string('_', _text.Length);
            return hiddenText;
        }
    }
    // Methods

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

}
// End Word.cs