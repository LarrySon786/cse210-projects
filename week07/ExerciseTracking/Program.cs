using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");


        List<Activity> activities = new List<Activity>();
        Run run = new Run("Running", 10, 1.25);
        Swim swim = new Swim("Swimming", 15, 30);
        Bicycle bicycle = new Bicycle("Cycling", 25, 20);
        activities.Add(run);
        activities.Add(swim);
        activities.Add(bicycle);

        foreach (Activity item in activities)
        {
            Console.WriteLine(item.GetSummary());
        }







    }
}