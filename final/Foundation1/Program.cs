using System;

class Program

{
    static void Main(string[] args)

    {
        // call to the list
        List<Video> videos = new List<Video>();

        // first vid
        Video vid1 = new Video();

        vid1._title = "How to make uranium-235 with common household objects";
        vid1._author = "Nuclear Man";
        vid1._videoLength = 614;

        // first vid comments
        Comment vid1comment1 = new Comment();
        Comment vid1comment2 = new Comment();
        Comment vid1comment3 = new Comment();

        vid1comment1._commentAuthor = "Linda Ibarra";
        vid1comment1._commentText = "how do you even know this?";

        vid1comment2._commentAuthor = "Youssef Lam";
        vid1comment2._commentText = "fascinating stuff!";

        vid1comment3._commentAuthor = "Angelina Pena";
        vid1comment3._commentText = "is this even legal?";

        // second vid
        Video vid2 = new Video();

        vid2._title = "Counting as many grains of sand as I can";
        vid2._author = "Way Too Much Time On My Hands";
        vid2._videoLength = 10981;

        // second vid comments
        Comment vid2comment1 = new Comment();
        Comment vid2comment2 = new Comment();
        Comment vid2comment3 = new Comment();

        vid2comment1._commentAuthor = "Aoife Chase";
        vid2comment1._commentText = "name checks out";

        vid2comment2._commentAuthor = "Tasnim Browning";
        vid2comment2._commentText = "Sir I applaud your patience.";

        vid2comment3._commentAuthor = "Marissa Brown";
        vid2comment3._commentText = "this was surprisingly entertaining";

        //third vid
        Video vid3 = new Video();

        vid3._title = "What if the moon was ten times bigger?";
        vid3._author = "What If";
        vid3._videoLength = 938;

        // third vid comments
        Comment vid3comment1 = new Comment();
        Comment vid3comment2 = new Comment();
        Comment vid3comment3 = new Comment();

        vid3comment1._commentAuthor = "Sadie Acosta";
        vid3comment1._commentText = "so tl;dr is we all die. Got it";

        vid3comment2._commentAuthor = "David Figueroa";
        vid3comment2._commentText = "my guy how do you even come up with these ideas?";

        vid3comment3._commentAuthor = "Elissa Dunn";
        vid3comment3._commentText = "I now have an irrational fear of the moon getting ten times bigger";

        // adding vids to the list
        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);

        // adding comments to each vid
        // fun fact
        vid1._comments.Add(vid1comment1);
        vid1._comments.Add(vid1comment2);
        vid1._comments.Add(vid1comment3);

        // vid authors were chosen based on the content
        vid2._comments.Add(vid1comment1);
        vid2._comments.Add(vid1comment2);
        vid2._comments.Add(vid1comment3);

        // while comment authors were chosen with a random name generator I found online
        vid3._comments.Add(vid1comment1);
        vid3._comments.Add(vid1comment2);
        vid3._comments.Add(vid1comment3);

        // printing them all out
        foreach (Video video in videos)

        {
            video.DisplayVideoDetails();
        }
    }
}