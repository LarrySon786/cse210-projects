using System;

public abstract class Activity
{
    private string _name;
    private double _duration;
    private DateTime _date;


    public Activity(string name, double duration)
    {
        _name = name;
        _duration = duration;
        _date = DateTime.Now;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_name} ({_duration} Minutes) - Distance: {GetDistance()} Miles, Speed: {GetSpeed()} MPH, Pace: {GetPace()} Minutes Per Mile";
    }

    
}