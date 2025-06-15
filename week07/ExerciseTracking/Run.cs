using System;

public class Run : Activity
{
    private double _distance;

    public Run(string name, double duration, double distance) : base(name, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}