using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                UpdateTotalScore(goal);
            }
        }
    }

    private void UpdateTotalScore(Goal goal)
    {
        totalScore += goal.Points;
        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
        {
            totalScore += checklistGoal.BonusPoints;
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    public int GetTotalScore()
    {
        return totalScore;
    }

    public void SaveGoals(string filename)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name + ":" + goal.Name + ":" + goal.Points);
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.CurrentCount}:{checklistGoal.TargetCount}:{checklistGoal.BonusPoints}");
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

        if (File.Exists(filePath))
        {
            goals.Clear();
            totalScore = 0;

            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(':');
                var type = parts[0];
                var name = parts[1];
                var points = int.Parse(parts[2]);

                if (type == nameof(SimpleGoal))
                {
                    goals.Add(new SimpleGoal(name, points));
                }
                else if (type == nameof(EternalGoal))
                {
                    goals.Add(new EternalGoal(name, points));
                }
                else if (type == nameof(ChecklistGoal))
                {
                    i++;
                    var checklistParts = lines[i].Split(':');
                    int currentCount = int.Parse(checklistParts[0]);
                    int targetCount = int.Parse(checklistParts[1]);
                    int bonusPoints = int.Parse(checklistParts[2]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, points, targetCount, bonusPoints)
                    {
                        CurrentCount = currentCount
                    };

                    if (currentCount >= targetCount)
                    {
                        checklistGoal.IsCompleted = true;
                    }

                    goals.Add(checklistGoal);
                }

                UpdateTotalScore(goals[goals.Count - 1]); 
            }

            Console.WriteLine($"Goals loaded from {filename}.");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }
}
