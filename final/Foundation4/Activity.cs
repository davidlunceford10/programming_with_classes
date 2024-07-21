public abstract class Activity
{
    private string _date;
    private int _activityLengthInMinutes;
    private string _activityType; 

    protected string date { get => _date; }
    protected int activityLengthInMinutes { get => _activityLengthInMinutes; }
    protected string activityType { get => _activityType; }

    public Activity(string date, int activityLengthInMinutes, string activityType)
    {
        _date = date;
        _activityLengthInMinutes = activityLengthInMinutes;
        _activityType = activityType;
    }

    public abstract string GetDistance();
    public abstract string GetSpeed();
    public abstract string GetPace();

    public virtual string GetSummary()
    {
        return $"{date} {activityType} ({activityLengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
