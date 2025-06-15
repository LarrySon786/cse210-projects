using System;

public class Bicycle : Activity
{

    private double _speed;

    public Bicycle(string name, double duration, double speed) : base(name, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / 60  * GetDuration();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}