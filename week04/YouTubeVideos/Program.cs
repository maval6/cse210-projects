using System;
using System.Collections.Generic;

// Comment class to store comment details
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Video class to store video details and associated comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Introduction to C#", "John Doe", 600),
            new Video("OOP Principles Explained", "Jane Smith", 900),
            new Video("Understanding Abstraction", "Alice Johnson", 720)
        };

        videos[0].AddComment(new Comment("User1", "Great video!"));
        videos[0].AddComment(new Comment("User2", "Very informative."));
        videos[0].AddComment(new Comment("User3", "Helped me a lot, thanks!"));

        videos[1].AddComment(new Comment("UserA", "Clear and concise explanation."));
        videos[1].AddComment(new Comment("UserB", "Nice examples!"));

        videos[2].AddComment(new Comment("UserX", "Loved the detailed explanation."));
        videos[2].AddComment(new Comment("UserY", "Thanks for this!"));
        videos[2].AddComment(new Comment("UserZ", "Very well structured."));

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
