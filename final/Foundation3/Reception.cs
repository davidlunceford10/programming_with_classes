public class Reception : Event
{
    private string _rsvpEmail { get; set; }

    private string rsvpEmail { get => _rsvpEmail; }

    public Reception(string eventTitle, string eventDescription, string date, string time, string address, string eventType, string rsvpEmail ) : base(eventTitle, eventDescription, date, time, address, eventType)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string DisplayFullDetails()
    {
        return$"Full Details: \n\nEvent Title: {eventTitle}\nDescription: {eventDescription}\nDate and Time: {date} at {time}.\nAddress: {address}\nType: {eventType}\nRSVP email: {rsvpEmail}";
    }
}