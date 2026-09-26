// Video.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Video
{
    // Member variables
    private string _title = "";
    private string _author = "";
    private int _length;
    private List<Comment> _comments = [];

    // Constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Getters and Setters

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Methods
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }
}
// End Video.cs