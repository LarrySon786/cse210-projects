using System;

public class Swim : Activity
{
    private double _laps;


    public Swim(string name, double duration, int laps) : base(name, duration)
    {
        _laps = laps;
    }


    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

}