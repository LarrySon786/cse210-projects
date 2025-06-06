using System;
using System.Security.Cryptography.X509Certificates;


class Activity
{
    private string _activityName;
    private string _description;
    private int _time;



    public Activity(string name, string desc)
    {
        _activityName = name;
        _description = desc;
        Console.WriteLine("How long would you like this activity to last? ");
        _time = int.Parse(Console.ReadLine());
    }


    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_activityName}");
        Console.WriteLine($"Description: {_description}");
        Pause(5);
        Console.WriteLine("Prepare to begin. ");
        Pause(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed the {_activityName}.");
        Console.WriteLine("Returning to menu. ");
        Pause(3);
        Console.Clear();

    }

    public void Pause(int seconds)
    {
        //Takes parameter seconds
        Console.WriteLine("");

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


    public void PauseSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Clear();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        Console.WriteLine("");

        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetTime()
    {
        return _time;
    }
    // public void DisplayPause()
    // {
    //     //Takes parameter seconds
    // }
}