public class Lecture : Event
{
    private string _speakerName { get; set; }
    private int _roomCapacity { get; set; }

    private string speakerName { get => _speakerName; }
    private int roomCapacity { get => _roomCapacity; }


    public Lecture(string eventTitle, string eventDescription, string date, string time, string address, string eventType, string speakerName, int roomCapacity ) : base(eventTitle, eventDescription, date, time, address, eventType)
    {
        _speakerName = speakerName;
        _roomCapacity = roomCapacity;
    }


    public override string DisplayFullDetails()
    {
        return$"Full Details: \n\nEvent Title: {eventTitle}\nDescription: {eventDescription}\nDate and Time: {date} at {time}.\nAddress: {address}\nType: {eventType}\nSpeaker: {speakerName}\nRoom Capacity: {roomCapacity}";
    }
}