using System;

public class ChecklistGoal : Goal
{
    int _targetAmount;
    int _amountCompleted;
    int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _targetAmount = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }



    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTargetAmount()
    {
        return _targetAmount;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override int AwardPoints()
    {
        if (_amountCompleted == _targetAmount)
        {
            return _bonus;
        }
        else
        {
            return 0;
        }
    }
    
    public void SetCompletion(int number)
    {
        _amountCompleted = number;
    }
    public override bool IsCompleted()
    {
        if (_targetAmount <= _amountCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string DisplayCompletion()
    {
        if (IsCompleted() == true)
        {
            return "[X]";
        }
        else
        {
            return $"[ ] - {_amountCompleted}/{_targetAmount}";
        }
    }
    public override void RecordProgress()
    {
        _amountCompleted = _amountCompleted + 1;
        // if (_amountCompleted >= _targetAmount)
        // {
        //     AwardBonus();
        // }
    }
    public override int GetNumberComplete()
    {
        return _amountCompleted;
    }
    public override int GetTarget()
    {
        return _targetAmount;
    }

}