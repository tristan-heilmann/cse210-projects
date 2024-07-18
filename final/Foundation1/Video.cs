using System.Transactions;

public class Video

{
    // member variables
    public string _title;
    public string _author;
    public int _videoLength;

    // comment list
    public List<Comment> _comments = new List<Comment>();
}