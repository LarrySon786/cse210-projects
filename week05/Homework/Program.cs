using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment assignment1 = new MathAssignment("7.2", "3-10", "Brandon", "Math");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("English for Pros", "Jimmy", "Writing Skills");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());


    }  
}

