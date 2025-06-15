using System;

public class EternalGoal : Goal
{


    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override bool IsCompleted()
    {
        return false;
    }
    public override string DisplayCompletion()
    {
        return "[ ]";
    }
    public override void RecordProgress()
    {
        //Grant points for completion
    }
    public override int GetBonus()
    {
        return 0;
    }
    public override int AwardPoints()
    {
        return GetPointValue();
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