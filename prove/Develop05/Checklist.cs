using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsCompleted = true;
            }
        }
    }

    public override string GetStatus()
    {
        return $"[{CurrentCount}/{TargetCount}] {(IsCompleted ? "[X]" : "[ ]")}";
    }

    public override string GetGoalType()
    {
        return "Checklist Goal";
    }
}
