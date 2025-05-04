using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        string fname;
        Console.WriteLine("What is your first name? ");
        fname = Console.ReadLine();
        string lname;
        Console.WriteLine("What is your last name? ");
        lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}

