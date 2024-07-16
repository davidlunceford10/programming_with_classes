class Video
{

    protected string _title;
    protected string _author;
    protected int _lengthSeconds;
    protected int _commentCount;
    public List<Comment> Comments { get; set; }
    

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
        
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
        _commentCount++;

    }

    public void DisplayVideoStuff()
    {
        Console.WriteLine($"\"{_title}\" - By {_author} - {_lengthSeconds} seconds - {_commentCount} Comments");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine("");
    }

}