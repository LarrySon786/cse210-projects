using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        float gradePercentage = float.Parse(gradeString);
        
        if (gradePercentage >= 90)
        {
            Console.WriteLine($"Your {gradePercentage} is an A");
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            Console.WriteLine($"Your {gradePercentage} is a B");
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            Console.WriteLine($"Your {gradePercentage} is a C");
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            Console.WriteLine($"Your {gradePercentage} is a D");
        }
        else if (gradePercentage < 60)
        {
            Console.WriteLine($"Your {gradePercentage} is an F");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}