using System;


class Comments
{
    private string _author;
    private string _text;



    public Comments(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine(_author);
        // Console.WriteLine("");
        Console.WriteLine(_text);
    }





}

