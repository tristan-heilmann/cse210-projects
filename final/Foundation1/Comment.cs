public class Comment

{
    // member variables
    public string _commentAuthor;
    public string _commentText;

    // comment details
    public void DisplayCommentDetails()

    {
        Console.WriteLine($"- {_commentAuthor}: {_commentText}");
    }    
}