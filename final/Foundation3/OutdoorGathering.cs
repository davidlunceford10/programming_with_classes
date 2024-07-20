public class OutdoorGathering : Event
{
    private string _statementOnWeather { get; set; }
    private string statementOnWeather {get => _statementOnWeather; }

    public OutdoorGathering(string eventTitle, string eventDescription, string date, string time, string address, string eventType, string statementOnWeather) : base(eventTitle, eventDescription, date, time, address, eventType)
    {
        _statementOnWeather = statementOnWeather;
    }

    public override string DisplayFullDetails()
    {
        return$"Full Details: \n\nEvent Title: {eventTitle}\nDescription: {eventDescription}\nDate and Time: {date} at {time}.\nAddress: {address}\nType: {eventType}\nStatement on Weather:\n{statementOnWeather}";
    }
}