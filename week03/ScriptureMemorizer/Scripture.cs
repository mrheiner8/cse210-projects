// Scripture.cs
using System;


// Create a class (custom data types) to use in Program
public class Scripture
{
    // Member variables
    private Reference _reference;
    private List<Word> _words;

    private string _test; //for testing

    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _test = text;
    }


    // Getters and Setters
    public string GetDisplayText()
    {
        return "";
    }

    // Methods
    public void HideRandomWords(int numberToHide)
    {
        numberToHide = 1;
        return;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}
// End Scripture.cs