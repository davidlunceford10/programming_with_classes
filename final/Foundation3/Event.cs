public abstract class Event
{
    private string _eventTitle { get; set; }
    private string _eventDescription { get; set; }
    private string _date { get; set; }
    private string _time { get; set; }
    private string _address { get; set; }
    private string _eventType { get; set; }

    protected string eventTitle { get => _eventTitle; }
    protected string eventDescription { get => _eventDescription; }
    protected string date { get => _date; }
    protected string time { get => _time; }
    protected string address { get => _address; }
    protected string eventType { get => _eventType; }

    public Event(string eventTitle, string eventDescription, string date, string time, string address, string eventType)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string DisplayStandardDetails()
    {
        return $"Event: {_eventTitle} \nDescription: \n{_eventDescription} \nThe {_eventTitle} will be held on {_date} at {_time}. \nAddress: {_address}";
    }

    public string DisplayShortDescription()
    {
        return $"Short Summary:\n\nEvent Type: {_eventType}\nEvent Title: {_eventTitle}\nEvent Date: {_date}";
    }

    public abstract string DisplayFullDetails();
}