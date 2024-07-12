class Checklist : Goal
{
    //Provide for a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus. For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.
    
    public override void BasicGoalInfo()
    {
        int goalType;
        string goalName = "";
        string goalDescription = "";
        int goalPointValue;
        double bonusRequirement;
        double bonusValue;

        Console.Write("What type of goal would you like to create? ");
        goalType = Console.Read();
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPointStringValue = Console.ReadLine();
        goalPointValue = int.Parse(goalPointStringValue);
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string bonusRequirementStringValue = Console.ReadLine();
        bonusRequirement = double.Parse(bonusRequirementStringValue);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusValueStringValue = Console.ReadLine();
        bonusValue = double.Parse(bonusValueStringValue);
    }
}