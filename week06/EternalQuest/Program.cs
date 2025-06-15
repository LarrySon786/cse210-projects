using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager([]);
        goalManager.Start();

        












        // Base Class - Goal
        //    _nameOfGoal
        //    _descriptionOfGoal
        //    _pointValueOfGoal
        //    Abstract IsCompleted()
        //    Abstract RecordEvent()
        //    Abstract GetStringRepresentation()
        //    Abstract GetDetailsString()



        // Derived Class - Simple Goal
        //    _isCompleted
        //    IsCompleted()

        // Derived Class - Eternal Goal
        //    IsCompleted()

        // Derived Class - CheckList Goal
        //    _isCompleted
        //    _howManyTimesToAccomplishGoal
        //    _bonusForCompletion
        //    IsCompleted()

        // GoalManager -
        //      _goal<LIST>
        //      _totalScore


        //Methods = Display the User's score

        //Main
        //Class - GoalManager
        // User has abilty to create new goals at any time
        // Allows user to record an event and mark when a goal is complete
        // Displays all completed and incomplete goals. Use a checkmark on completed goals... maybe try the emoji keyboard.
        //           Use a 2/5 or something like that on incomplete goals 
        // Save their goals to a file
        // Load their goals from a file

        //MAIN CLASS GOALMANAGER Functions
        //Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        //DisplayPlayerInfo - Displays the players current score.
        // ListGoalNames - Lists the names of each of the goals.
        // ListGoalDetails - Lists the details of each goal(including the checkbox of whether it is complete).
        // CreateGoal - Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
        // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        // SaveGoals - Saves the list of goals to a file.
        // LoadGoals - Loads the list of goals from a file.  

    }
}