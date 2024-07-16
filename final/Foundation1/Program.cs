using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Here's some funny internet videos!\n");

        
        Video video1 = new Video("Math Homework", "Bob", 300);

        Comment comment1 = new Comment("Mark", "This is oddly fulfilling!");
        Comment comment2 = new Comment("Dan", "I think his old videos were the best ones");
        Comment comment3 = new Comment("Dave", "I'm gonna have to study this more");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Art", "Various Artists", 420);

        Comment v2comment1 = new Comment("Herold", "I love the painting at 0:47");
        Comment v2comment2 = new Comment("bigsniper360", "was looking for memes and found this in my recommended");
        Comment v2comment3 = new Comment("Mary101", "good video, might watch later");
        Comment v2comment4 = new Comment("Ken", "I might have to buy one of these paintings, I really do like these!");
        video2.AddComment(v2comment1);
        video2.AddComment(v2comment2);
        video2.AddComment(v2comment3);
        video2.AddComment(v2comment4);

        Video video3 = new Video("Redbull Snow 2024", "RedBull", 600);

        Comment v3comment1 = new Comment("Bill Murray", "heck yeah!");
        Comment v3comment2 = new Comment("Mark Rober", "I love these videos!");
        Comment v3comment3 = new Comment("SwanRakeRizzler", "bruh I could make that jump");
        video3.AddComment(v3comment1);
        video3.AddComment(v3comment2);
        video3.AddComment(v3comment3);

        List<Video> VideoList = new List<Video>();
        
        VideoList.Add(video1);
        VideoList.Add(video2);
        VideoList.Add(video3);

        foreach (Video video in VideoList)
        {
            video.DisplayVideoStuff();
        }
        



    }
}