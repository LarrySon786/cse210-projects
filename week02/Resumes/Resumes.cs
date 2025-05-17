public class Resumes
{
    public string _name;
    public List<Job> _jobs = new List<Job>();


    public void DisplayResumes()
    {
        Console.WriteLine($"Name: {_name}");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}