using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // job1.DisplayJob();
        // job2.DisplayJob();

        Resumes myResume = new Resumes();
        myResume._name = "Brandon Richards";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResumes();
    }
}




