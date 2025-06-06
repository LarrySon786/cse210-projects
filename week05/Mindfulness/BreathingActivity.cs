using System;

class BreathingActivity : Activity
{

    public BreathingActivity(string name, string desc) : base(name, desc)
    {
        
    }
    public void Run()
    {
        //run's this activity
        DisplayStartMessage();
        Console.WriteLine("Begin! ");
        int seconds = GetTime();
        for (int i = seconds; seconds > 0; seconds -= 12)
        {
            Console.WriteLine("Breath in...");
            Pause(6);
            Console.WriteLine("Breath out.");
            Pause(6);
        }
        DisplayEndMessage();
    }
}