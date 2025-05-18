using System;
using System.IO;

class Journal
{
    public string _journalName;
    public Entry _entry;
    public List<Entry> _entries = new List<Entry>();

    public void SaveEntry()
    {
        Console.WriteLine("Enter the name of the file where you want to store your entries. ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry1 in _entries)
                outputFile.WriteLine($"{entry1._date}~{entry1._textWritten}");
        }
        
    }

    public void LoadEntry()
    {
        Console.WriteLine("Enter the name of your Journal's File ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();


        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            Entry entry1 = new Entry();
            entry1._date = Convert.ToString(parts[0]);
            entry1._textWritten = Convert.ToString(parts[1]);

            _entries.Add(entry1);


        }

    }

    public void AddEntry()
    {
        Prompt prompt1 = new Prompt();
        prompt1._prompt = prompt1.GeneratePrompt();
        Console.WriteLine(prompt1._prompt);

        Entry entry1 = new Entry();
        entry1._date = Convert.ToString(DateTime.Today);
        
        Console.WriteLine($"{entry1._date} Entry: ");
        Console.WriteLine("");
        entry1._textWritten = Console.ReadLine();

        _entries.Add(entry1);

    }

    public void DisplayAllEntries()
    {
        foreach (Entry entries in _entries)
        {
            entries.DisplayEntry();
        }
    }



}