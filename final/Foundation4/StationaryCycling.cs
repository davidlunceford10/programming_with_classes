public class StationaryCycling : Activity
{
    private double _cyclingDistance;
    protected double cyclingDistance { get => _cyclingDistance; }

    public StationaryCycling(string date, int activityLengthInMinutes, string activityType, double cyclingDistance) : base(date, activityLengthInMinutes, activityType)
    {
        _cyclingDistance = cyclingDistance;
    }

    public override string GetDistance()
    {
        return $"{cyclingDistance:F2}";
    }

    public override string GetSpeed()
    {
        double speed = (cyclingDistance / activityLengthInMinutes) * 60;
        return $"{speed:F2}";
    }

    public override string GetPace()
    {
        double pace = activityLengthInMinutes / cyclingDistance;
        return $"{pace:F2}";
    }
}
