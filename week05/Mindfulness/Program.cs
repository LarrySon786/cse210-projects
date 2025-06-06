using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string answer = "";
        string name = "";
        string description = "";
        int logBreath = 0;
        int logReflect = 0;
        int logList = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Select your Activity ");
            Console.WriteLine("1. Breathing Exercise ");
            Console.WriteLine("2. Reflection Activity ");
            Console.WriteLine("3. Listing Activity ");
            Console.WriteLine("0. Quit");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                logBreath = logBreath + 1;
                name = "Breathing Actvity";
                description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                // Console.WriteLine("How long would you like this activity to last? ");
                // seconds = int.Parse(Console.ReadLine());
                BreathingActivity breathingActivity = new BreathingActivity(name, description);
                breathingActivity.Run();

            }
            else if (answer == "2")
            {
                logReflect = logReflect + 1;
                name = "Reflection Actvity";
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ";
                // Console.WriteLine("How long would you like this activity to last? ");
                // seconds = int.Parse(Console.ReadLine());
                ReflectingActivity reflectActivity = new ReflectingActivity(name, description);
                reflectActivity.Run();
            }
            else if (answer == "3")
            {
                logList = logList + 1;
                name = "Listing Actvity";
                description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ";
                // Console.WriteLine("How long would you like this activity to last? ");
                // seconds = int.Parse(Console.ReadLine());
                ListingActivity listActivity = new ListingActivity(name, description);
                listActivity.Run();
            }

        } while (answer != "0");

        Console.WriteLine("Number of times each acivity was performed. ");
        Console.WriteLine($"Breathing Activity: {logBreath}. ");
        Console.WriteLine($"Reflecting Activity: {logReflect}.");
        Console.WriteLine($"Listing Activity: {logList}.");



    }
}

//Classes - shared methods
//Time countdown
//Spinning ... symbols
//



//Requirements:

//Menu system to choose activity
//Each activity has a common message with the title of activity, description, and asks the user how ling they want the activity to last. Then it should tell the user to prepare to being and pause for several seconds.
//Each activity ends with a common message. THen display the activity that was completed and the length of time it took. Then pauses for several seconds before finishing.
//Whenever there is a pause in program, it ocunts down on screen.
//mimic video demo


//Activity

//Breathing activity



//Reflection Activity - think about time they demonstrated strength or had success


//Listing Activity - User lists things broadly about their certain area of strength or positivity


//Track time they use in these activities.
