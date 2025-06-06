using System;

class ListingActivity : Activity
{


    private List<string> _prompts = new List<string>();
    private List<string> _ponderings = new List<string>();



    public ListingActivity(string name, string desc) : base(name, desc)
    {
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            ];
    }

    public void Run()
    {
        //run's this activity


        DisplayStartMessage();
        Console.WriteLine(GeneratePrompt());
        Console.WriteLine("");

        int numberOfEntries = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTime());
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            string entry = Console.ReadLine();
            numberOfEntries = numberOfEntries + 1;
            _ponderings.Add(entry);
            currentTime = DateTime.Now;
        } 

        foreach (string item in _ponderings)
        {
            Console.WriteLine(item);
            Console.WriteLine("");
        }
        Pause(7);

        DisplayEndMessage();

    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public void GetListFromUser(int seconds)
    {
        do
        {
            _ponderings.Add("");
        } while (seconds > 0);
    }
}