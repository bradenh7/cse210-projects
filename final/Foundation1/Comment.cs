using System;

public class Comment
{
    private string _text; // Text of the comment
    private string _author;   // Author of the comment

    public Comment(string text, string author) // Constructor to initialize the comment with text and author
    {
        _text = text;
        _author = author;
    }

    public void Display() // Method to display the comment
    {
        Console.WriteLine($"Comment by {_author}: {_text}");
    }
}