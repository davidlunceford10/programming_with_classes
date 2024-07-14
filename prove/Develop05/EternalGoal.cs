using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never completed, but points are added each time
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetGoalType()
    {
        return "Eternal Goal";
    }
}



