using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            int totalPoints = goalManager.GetTotalScore();
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals (Goal files are saved to bin folder)");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Please select an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    SaveGoals(goalManager);
                    break;
                case "4":
                    LoadGoals(goalManager);
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        

        Console.Write("Please select an option: ");

        string goalType = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target count for the goal: ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points for the goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goalManager.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the file name to save goals: ");
        string fileName = Console.ReadLine();
        goalManager.SaveGoals(fileName);
        Console.WriteLine($"Goals saved to {fileName}.");
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the file name to load goals: ");
        string fileName = Console.ReadLine();
        goalManager.LoadGoals(fileName);
        Console.WriteLine($"Goals loaded from {fileName}.");
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.Write("Enter the name of the goal to record: ");
        string goalName = Console.ReadLine();

        goalManager.RecordEvent(goalName);
        Console.WriteLine($"Event recorded for goal: {goalName}");
    }
}