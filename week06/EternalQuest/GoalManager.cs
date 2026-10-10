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
        /*
        Menu Options:\n    1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n    5. Record Event\n    6. Quit 
        Select a Choice from the Menu:
        */
    }
    public void DisplayPlayerInfo()   // Displays the players current score.
    {
        //You have {} points. 
    }
    public void ListGoalNames()   // Lists the names of each of the goals.
    {
        //The Goals are:\n    1. { name of goal input}\n   2. { name of goal input}\n    3. { name of goal input}
    }
    public void ListGoalDetails()  // Lists the details of each goal (including the checkbox of whether it is complete).
    {
        // The Goals are: 1. [    ]  { name of goal input}{ (description input)}2. [    ]  { name of goal input}{ (description input)}3. [    ]  { name of goal input}{ (description input)}    --Currently Completed: 0 of 3

    }
    public void CreateGoal()   // Asks the user for the information about a new goal.Then, creates the goal and adds it to the list.
    {
        /*
        The types of Goals are: 
	    1. Simple Goal
	    2. Eternal Goal //on going goal. Will not show as completed.
	    3. Checklist Goal. 
        Which type of goal would you like to create? 3
        What is the name of your goal? (string input)
        What is a short description of it? (string input)
        What is the amount of points associated with this goal? (Int input)
        How many times does this goal need to be accomplished for a bonus?  (Int input)
        What is the bonus for accomplishing it that many times? (Int input)
        */
    }
    public void RecordEvent()   // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    {
        /*
        The Goals are:
        1. { name of goal input}
        2. { name of goal input}
        3. { name of goal input}
        Which gold did you accomplish ? 2
        Congratulations! You have earned { int input}
        points.
        You now have { int input}
        points.
        */
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