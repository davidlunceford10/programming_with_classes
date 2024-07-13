public class Goal 
{

    protected int _goalType;
    protected string _goalName = "";
    protected string _goalDescription = "";
    protected int _goalPointValue;

    public Goal(int goalType, string goalName, string goalDescription, int goalPointValue)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPointValue = goalPointValue;
    }

    
    public virtual void CreateNewGoal()
    {
               
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");

        Console.Write("What type of goal would you like to create? ");
        _goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPointValue = int.Parse(Console.ReadLine());
        
    }

    public void ListGoals()
    {

    }
}
   