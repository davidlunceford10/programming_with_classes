public class Goal //Base Goal
{
    protected string _goalType { get; set; }
    protected string _goalName { get; set; }
    protected string _goalDescription { get; set; }
    protected int _goalPointValue { get; set; }
    protected double _totalScore;

    public Goal(string goalType, string goalName, string goalDescription, int goalPointValue)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPointValue = goalPointValue;
    }

    public override string ToString()
    {
        return $"{_goalType}#{_goalName}#{_goalDescription}#{_goalPointValue}";
    }

    public static void BasicGoalInfo(List<Goal> goals)
    {
        

        string goalType = "";
        string goalName = "";
        string goalDescription = "";
        int goalPointValue;

        Console.Write("What type of goal would you like to create? ");
        goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPointStringValue = Console.ReadLine();
        goalPointValue = int.Parse(goalPointStringValue);

        Goal newGoal = new Goal(goalType, goalName, goalDescription, goalPointValue);
        goals.Add(newGoal);
        
    }

    public void SaveGoalsToFile(List<Goal> goals, string filePath)
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        foreach (var goal in goals)
        {
            writer.WriteLine(goal.ToString());
        }
    }
    Console.WriteLine("Goals have been saved to the file.");
}

    public virtual void Score()
    {
        _totalScore = 0;

    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("Type the number of the goal you want to record an event for: ");

    }



    
}