using System;


class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        Console.WriteLine("What book is your scripture in? (1 Nephi, Alma, John, Revelations, ect)");
        _book = Console.ReadLine();
        Console.WriteLine("What chapter is your scripture in?");
        string userInput = Console.ReadLine();
        _chapter = int.Parse(userInput);
        Console.WriteLine("What verse does your scripture start on? ");
        userInput = Console.ReadLine();
        _verse = int.Parse(userInput);
        Console.WriteLine("What verse does your scripture end on? ");
        userInput = Console.ReadLine();
        _endVerse = int.Parse(userInput);

    }

    public string GetDisplayReference()
    {
        string reference = $"{_book} {_chapter}: {_verse}-{_endVerse}";
        return reference;
    }

    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerses()
    {
        return _verse;
    }
}



