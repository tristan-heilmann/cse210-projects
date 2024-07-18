using System.Transactions;

public class Video

{
    // member variables
    public string _title;
    public string _author;
    public int _videoLength;

    // comment list
    public List<Comment> _comments = new List<Comment>();

    // vid details
    public void DisplayVideoDetails()

    {
        // writing out the vids
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in seconds: {_videoLength}");
        
        // counting comments
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        Console.WriteLine();

        // printing comments
        foreach (Comment comment in _comments)

        {
            comment.DisplayCommentDetails();
        }
    }
}