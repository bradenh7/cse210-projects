using System;

public class Video
{
    private string _title; // Title of the video
    private string _author; // Author of the video
    private int _duration; // Duration of the video in seconds

    private List<Comment> _comments; // List of comments on the video

    public Video(string title, string author, int duration) // Constructor to initialize the video with title, author, and duration
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }


    public void AddComment(Comment comment) // Method to add a comment to the video
    {
        _comments.Add(comment);
    }

    public int CommentCount() // Method to get the count of comments on the video
    {
        return _comments.Count;
    }
    
    public void Display() // Method to display the video details and its comments
    {
        Console.WriteLine($"Video: {_title} by {_author}, Duration: {_duration} seconds");
        Console.WriteLine($"Comments ({CommentCount()}):");
        foreach (var comment in _comments) // Iterate through each comment and display it
        {
            comment.Display();
        }
    }
    


}