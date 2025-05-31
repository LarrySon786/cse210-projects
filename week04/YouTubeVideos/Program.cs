using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();
        List<Comments> comments = new List<Comments>();

        string title = "How to open a car when you've lost your keys ";
        string author = "Brandon";
        int length = 632;
        string creator1 = "James";
        string creator2 = "Susie";
        string creator3 = "Lucy";
        string commentText1 = "This was very helpful! ";
        string commentText2 = "I've been looking everywhere for something like this. ";
        string commentText3 = "You make it look so easy. ";

        Comments comment1 = new Comments(creator1, commentText1);
        Comments comment2 = new Comments(creator2, commentText2);
        Comments comment3 = new Comments(creator3, commentText3);

        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);

        Video video1 = new Video(title, author, length, comments);
        videos.Add(video1);

        comments.Clear();

        //Video 2 information

        title = "How to make the greatest sandwitch";
        author = "Charlie";
        length = 478;
        creator1 = "Billy";
        creator2 = "Bob";
        creator3 = "Joe";
        commentText1 = "Thank you! ";
        commentText2 = "Great video. ";
        commentText3 = "Can you do a part 2? ";

        comment1 = new Comments(creator1, commentText1);
        comment2 = new Comments(creator2, commentText2);
        comment3 = new Comments(creator3, commentText3);

        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);

        Video video2 = new Video(title, author, length, comments);
        videos.Add(video2);

        comments.Clear();

        //Video 3 information

        title = "Pro tips for programing with Javascript";
        author = "Matthew";
        length = 382;
        creator1 = "Henry";
        creator2 = "Gina";
        creator3 = "Xavier";
        commentText1 = "This was a great example! ";
        commentText2 = "This fix worked. Thanks a bunch! ";
        commentText3 = "I had issues fixing the settings for display. Does anyone know what to do? ";

        comment1 = new Comments(creator1, commentText1);
        comment2 = new Comments(creator2, commentText2);
        comment3 = new Comments(creator3, commentText3);

        comments.Add(comment1);
        comments.Add(comment2);
        comments.Add(comment3);

        Video video3 = new Video(title, author, length, comments);
        videos.Add(video3);

        comments.Clear();


        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}





//Classes
//1) video - Attributes - track's title, author, length in seconds. Also stores a List<comments> of comments
//2) Comments - Attributes - track's name of person making comment, text of comment.

// Write program that creates 3 videos with 3 comments each
// Create a list of List<video> in main program

//Display all video titles, authors, length, number of comments, and actual comment information in main

//Methods  Behavior
//video - Iterate through video List to display video title, author, length, and number of comments. Calls the comment display method to display comments.
//Comments - Iterate through comments List. Display comment will print the Author and text of their comment.
