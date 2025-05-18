using System;

class Entry
{
    public string _date;
    public string _textWritten;

    public void DisplayEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_textWritten}");
        Console.WriteLine("");
    }


}