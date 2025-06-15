using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    // List<Goal> _goalsCompleted = new List<Goal>();
    int _score;

    public GoalManager(List<Goal> goals)
    {
        _score = 0;
        foreach (Goal goal in goals)
        {
            _goals.Add(goal);
            // _goalsCompleted = [];
        }
    }

    public void AddGoalToManager(Goal goal)
    {
        _goals.Add(goal);
    }

    public void Start()
    {
        string answer = "";
        do
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create Goals ");
            Console.WriteLine("2. List Goals ");
            Console.WriteLine("3. Save Goals ");
            Console.WriteLine("4. Load Goals ");
            Console.WriteLine("5. Record Event ");
            Console.WriteLine("6. Quite ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                CreateGoal();
            }
            else if (answer == "2")
            {
                DisplayGoals();
            }
            else if (answer == "3")
            {
                SaveGoals();
            }
            else if (answer == "4")
            {
                LoadGoals();
            }
            else if (answer == "5")
            {
                RecordEvent();
            }
        } while (answer != "6");
    }
    public void CreateGoal()
    {
        string goalName = "";
        string goalDescription = "";
        int goalPoints = 0;
        int targetAttempts = 0;

        Console.Clear();
        Console.WriteLine("What type of Goal would you like to create? ");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Checklist Goal ");
        string goalChoice = "";
        goalChoice = Console.ReadLine();

        if (goalChoice == "1")
        {
            Console.Clear();
            Console.WriteLine("Please name your goal: ");
            goalName = Console.ReadLine();
            Console.WriteLine("Please enter a goal Description: ");
            goalDescription = Console.ReadLine();
            Console.WriteLine("Please enter how many points this goal will be worth: ");
            goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal goal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(goal);
        }
        else if (goalChoice == "2")
        {
            Console.Clear();
            Console.WriteLine("Please name your goal: ");
            goalName = Console.ReadLine();
            Console.WriteLine("Please enter a goal Description: ");
            goalDescription = Console.ReadLine();
            Console.WriteLine("Please enter how many points this goal will be worth when completed once: ");
            goalPoints = int.Parse(Console.ReadLine());

            EternalGoal goal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(goal);
        }
        else if (goalChoice == "3")
        {
            Console.Clear();
            Console.WriteLine("Please name your goal: ");
            goalName = Console.ReadLine();
            Console.WriteLine("Please enter a goal Description: ");
            goalDescription = Console.ReadLine();
            Console.WriteLine("What is your target for this goal? ");
            targetAttempts = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many points this goal will be worth when the checklist is completed: ");
            goalPoints = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, 0, targetAttempts, goalPoints);
            _goals.Add(goal);
        }
    }

    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine("-----------------------");
        int displayTotal = 0;
        foreach (Goal goal in _goals)
        {
            displayTotal = displayTotal + 1;
            Console.WriteLine($"{displayTotal}. {goal.DisplayCompletion()} - {goal.GetName()}:  {goal.GetDescription()}");
            Console.WriteLine();
        }
        Console.WriteLine("-----------------------");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Please type the number of the goal that you would like to mark complete or report as progress made: ");
        int index = 0;
        int pointsGained = 0;
        index = int.Parse(Console.ReadLine());
        index = index - 1;
        _goals[index].RecordProgress();
        pointsGained = _goals[index].AwardPoints();
        _score = _score + pointsGained;
    }
    public void SaveGoals()
    {
        string filename = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
                if (goal is SimpleGoal)
                {
                    outputFile.WriteLine($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPointValue()},{goal.IsCompleted()}");
                }
            foreach (Goal goal in _goals)
                if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPointValue()}");
                }
            foreach (Goal goal in _goals)
                if (goal is ChecklistGoal)
                {
                    outputFile.WriteLine($"{goal.GetType()},{goal.GetName()},{goal.GetDescription()},{goal.GetBonus()},{goal.GetTarget()},{goal.GetNumberComplete()}");
                }
        }
    }
    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (parts[4] == "True")
                    goal.SetComplete();
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], 0, int.Parse(parts[4]), int.Parse(parts[3]));
                goal.SetCompletion(int.Parse(parts[5]));
                _goals.Add(goal);
            }

        }
    }








}