// GoalManager.cs
using System;

// Create a class (custom data types) to use in Program
public class GoalManager
{
    // Member variables
    private List<Goal> _goals = [];
    private int _score;


    // Constructors
    public /*void*/ GoalManager() // Initializes an empty list of goals and sets the player's score to be 0.
    {

    }
    // Getters and Setters
    public int GetScore()
    {
        return _score;
    }

    public void SetAmountCompleted(int score)
    {
        _score = score;
    }

    // Methods
    public void Start()  // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    {
        string choice = "0";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.Write("Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit\nSelect a Choice from the Menu: ");
            choice = Console.ReadLine();
            // Console.Clear(); maybe I will keep this in 

            if (choice == "1") // 1. Create New Goal
            {
                CreateGoal();
            }
            else if (choice == "2") // 2. List Goals
            {
                ListGoalDetails();
            }
            else if (choice == "3") // 3. Save Goals
            {
                SaveGoals();
            }
            else if (choice == "4") // 4. Load Goals
            {
                LoadGoals();
            }
            else if (choice == "5") // 5. Record Event
            {
                RecordEvent();
            }
            else if (choice == "6") // 6. Quit\
            {
                Console.WriteLine("\nThank you have a nice day!");
            }
            else // Wrong input
            {
                Console.WriteLine("\nI'm sorry that was an invalid response. Please select 1, 2, 3, 4, 5, or 6.\n");
            }
        }
    }
    public void DisplayPlayerInfo()   // Displays the players current score.
    {
        Console.WriteLine($"\nYou Have {GetScore()} Points\n");
    }
    public void ListGoalNames()   // Lists the names of each of the goals.
    {
        Console.WriteLine("The Goals are:"); 
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter++;
            Console.WriteLine($"    {counter}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()  // Lists the details of each goal (including the checkbox of whether it is complete).
    {
        Console.WriteLine("The Goals are:");   //--Currently Completed: 0 of 3
        int counter = 0;
        foreach (Goal goal in _goals)
        {
            counter++;
            Console.WriteLine($"    {counter}. {goal.GetDetailsString()}");
        }
    }
    public void CreateGoal()   // Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
    {
        string choice = "0";
        DisplayPlayerInfo();
        Console.Write("The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of goal would you like to create? ");
        choice = Console.ReadLine();

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
        }
        else
        {
            Console.WriteLine("Error: That was not a valid integer.\nWhat is the amount of points associated with this goal? ");
        }

        if (choice == "1") // 1. Simple Goal
        {
            Goal newSimpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(newSimpleGoal);
        }
        else if (choice == "2") // 2. Eternal Goals
        {
            Goal newEternalGoal = new EternalGoal(name, description, points);
            _goals.Add(newEternalGoal);
        }
        else if (choice == "3") // 3. Checklist Goals
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?  (Int input)");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                // 
            }
            else
            {
                Console.WriteLine("Error: That was not a valid integer.");
            }
            Console.Write("What is the bonus for accomplishing it that many times? (Int input)");
            if (int.TryParse(Console.ReadLine(), out int bonus))
            {
                // 
            }
            else
            {
                Console.WriteLine("Error: That was not a valid integer.");
            }
            Goal newChecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newChecklistGoal);
        }
    }
    public void RecordEvent()   // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish ?");
        int finishedGoal = int.Parse(Console.ReadLine());
        int goalIndex = finishedGoal - 1;
        Goal chosenGoal = _goals[goalIndex];
        int pointsEarned = chosenGoal.RecordEvent();
        
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        _score += pointsEarned;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()  // Saves the list of goals to a file.
    {
        //What is the file name for the goal file? (input) goals.txt

    }
    public void LoadGoals()  // Loads the list of goals from a file.
    {
        //What is the file name for the goal file? (input) goals.txt

    }

}
// End GoalManager.cs