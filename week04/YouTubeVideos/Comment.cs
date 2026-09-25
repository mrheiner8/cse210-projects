// Comment.cs
using System;

// Create a class (custom data types) to use in Program
public class Comment
{
    // Member variables
    private string _commenter = "";
    private string _comment = "";

    // Constructors
    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    // Getters and Setters
    public string GetDisplayText()
    {
        return $"{_commenter}: {_comment}";
    }
}
// End Comment.cs