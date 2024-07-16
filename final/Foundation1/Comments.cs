class Comment 
{

    string _commentAuthor;
    string _commentText;

    

    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _commentText = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commentAuthor}: {_commentText}");
    }

}