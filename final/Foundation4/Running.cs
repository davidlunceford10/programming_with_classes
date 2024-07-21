public class Running : Activity
{
    private double _runningDistance;
    protected double runningDistance {get => _runningDistance; }
    public Running(string date, int activityLengthInMinutes, string activityType, double runningDistance) : base(date, activityLengthInMinutes, activityType)
    {
        _runningDistance = runningDistance;
    }

    public override string GetDistance()
    {
        return $"{runningDistance:F2}";
    }

    public override string GetSpeed()
    {
        double speed = (runningDistance / activityLengthInMinutes) * 60;
        return $"{speed:F2}";
    }

    public override string GetPace()
    {
        double pace = activityLengthInMinutes / runningDistance;
        return $"{pace:F2}";
    }

    


}