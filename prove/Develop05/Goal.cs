class Goal //Base Goal
{
    private double _score;

    public virtual void BasicGoalInfo()
    {
        List<Goal> Goals = new List<Goal>();

        int goalType;
        string goalName = "";
        string goalDescription = "";
        int goalPointValue;

        Console.Write("What type of goal would you like to create? ");
        goalType = Console.Read();
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPointStringValue = Console.ReadLine();
        goalPointValue = int.Parse(goalPointStringValue);
    }



    
}