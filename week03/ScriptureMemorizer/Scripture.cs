// Scripture.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Scripture
{
    // Member variables (fields)
    private Reference _reference;
    private List<Word> _words;
    private Random _random;


    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

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

        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = _random.Next(0, _words.Count);

            Word wordToHide = _words[randomIndex];
            wordToHide.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}
// End Scripture.cs