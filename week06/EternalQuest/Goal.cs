using System;

public abstract class Goal
{
    string _name;
    string _description;
    int _pointValue;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _pointValue = points;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public abstract bool IsCompleted();
    public abstract string DisplayCompletion();
    public abstract void RecordProgress();
    public abstract int GetBonus();
    public abstract int GetTarget();
    public abstract int GetNumberComplete();
    public abstract int AwardPoints();

}