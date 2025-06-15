using System;

public class SimpleGoal : Goal
{
    bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }
    public void SetComplete()
    {
        _isCompleted = true;
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }
    public override string DisplayCompletion()
    {
        if (IsCompleted() == true)
        {
            return "[X]";
        }
        else if (IsCompleted() == false)
        {
            return "[ ]";
        }
        else
        {
            return "[ ]";
        }

    }
    public override void RecordProgress()
    {
        _isCompleted = true;
    }
    public override int AwardPoints()
    {
        return GetPointValue();
    }
    public override int GetBonus()
    {
        return 0;
    }
    public override int GetTarget()
    {
        return 0;
    }
    public override int GetNumberComplete()
    {
        return 0;
    }



}