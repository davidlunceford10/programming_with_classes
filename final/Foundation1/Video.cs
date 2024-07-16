class Video
{

    protected string _title;
    protected string _author;
    protected int _lengthSeconds;
    public List<Comment> Comments { get; set; }
    

    public Video(string title, string author, int lengthSeconds)
    {
        title = _title;
        author = _author;
        lengthSeconds = _lengthSeconds;
        Comments = new List<Comment>();
        
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayVideoStuff()
    {
        Console.WriteLine($"{_title} - {_author} {_lengthSeconds}");
    }

}