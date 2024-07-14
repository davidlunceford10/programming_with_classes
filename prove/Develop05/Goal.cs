using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string GetGoalType();

    public override string ToString()
    {
        return $"{Name} ({GetGoalType()}) - {GetStatus()}";
    }
}