using System;



class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments = new List<Comments>();


    public Video(string name, string creator, int length, List<Comments> comments)
    {
        _title = name;
        _author = creator;
        _length = length;

        foreach (Comments item in comments)
        {
            _comments.Add(item);
        }
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: { _author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        Console.WriteLine("");

        foreach (Comments item in _comments)
        {
            item.DisplayComment();
            Console.WriteLine("");
        }
        Console.WriteLine("________________________________________________________");
    }




}
