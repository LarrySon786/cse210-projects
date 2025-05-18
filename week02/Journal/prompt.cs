using System;

class Prompt
{
    public string _prompt;

    public string GeneratePrompt()
    {

        List<string> promptChoices = new List<string> { "What was the funniest Thing that happened today?", "Write about something that made you smile.", "What is a lesson learned today.", "What is one thing from today that you would like to remember? ", "Have you seen the hand of the Lord in your life today? " };

        int listLength = promptChoices.Count();
        Random randomGenerator = new Random();
        int randomPromptIndex = randomGenerator.Next(1, listLength);
        string randomPrompt = promptChoices[randomPromptIndex];
        return randomPrompt;
    }

}