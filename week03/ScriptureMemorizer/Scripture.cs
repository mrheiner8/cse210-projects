// Scripture.cs
using System;
using System.Collections.Generic;
using System.IO;



// Create a class (custom data types) to use in Program
public class Scripture
{
    // Member variables
    private Reference _reference;
    private List<Word> _words;


    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string oneWord in splitWords)
        {
            Word single = new Word(oneWord);
            _words.Add(single);

        }
    }

    // Getters and Setters
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word single in _words)
        {
            displayText += $"{single.GetDisplayText()} ";
        }
        return $"\n{_reference.GetDisplayText()} \n{displayText}\n";
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