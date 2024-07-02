class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string _studentName, string topic, string title) : base(_studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }




}