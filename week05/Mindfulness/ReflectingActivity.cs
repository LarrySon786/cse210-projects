using System;

class ReflectingActivity : Activity
{


    private List<string> _storedPrompts = new List<string>();
    private List<string> _questions = new List<string>();



    public ReflectingActivity(string name, string desc) : base(name, desc)
    {
        _storedPrompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            ];
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            ];

    }
    public void Run()
    {
        //run's this activity
        DisplayStartMessage();
        Console.Write("Your Prompt: ");
        Console.WriteLine(GeneratePrompt());
        PauseSpinner(12);
        //Must display spinner
        for (int i = GetTime(); i > 0; i -= 8)
        {
            Console.WriteLine(GenerateQuestion());
            PauseSpinner(12);
            // Console.WriteLine("");
        }

        DisplayEndMessage();

    }
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_storedPrompts.Count);
        string prompt = _storedPrompts[index];
        return prompt;
    }
    public void DisplayPrompt()
    {
        // Console.WriteLine("");
        Console.WriteLine(GeneratePrompt());
        // Console.WriteLine("");
    }

    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }
    public void DisplayQuestionGetAnswer()
    {
        Console.WriteLine(GenerateQuestion());

        // Console.ReadLine();
    }

}