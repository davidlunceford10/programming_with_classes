public class Swimming : Activity
{
    private int _lapCount;
    private double _swimmingDistance;

    protected int lapCount => _lapCount;
    protected double swimmingDistance => _swimmingDistance;

    public Swimming(string date, int activityLengthInMinutes, string activityType, int lapCount) : base(date, activityLengthInMinutes, activityType)
    {
        _lapCount = lapCount;
        _swimmingDistance = lapCount * 50 / 1000.0 * 0.62;
    }

    public override string GetDistance()
    {
        return $"{_swimmingDistance:F2}";
    }

    public override string GetSpeed()
    {
        double speed = (_swimmingDistance / activityLengthInMinutes) * 60;
        return $"{speed:F2}";
    }

    public override string GetPace()
    {
        double pace = activityLengthInMinutes / _swimmingDistance;
        return $"{pace:F2}";
    }

    public override string GetSummary()
    {
        return $"{date} {activityType} ({activityLengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
