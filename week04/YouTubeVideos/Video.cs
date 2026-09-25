// Video.cs
using System;
using System.Collections.Generic;

// Create a class (custom data types) to use in Program
public class Video
{
    // Member variables
    private string _title = "";
    private string _author = "";
    private int _length ;
    private List<Comment> _comments = [];

    // Constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    // Getters and Setters

    // Methods
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public static int NumberOfComments()
    {
        return 1; //place holder needs to be replaced
    }
}
// End Video.cs