// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Name and create 1st 'Video' instance
        Video v1 = new Video("test Name1", "Test Author1", 111);
        Comment v1c1 = new Comment("commenter v1c1", "Comment v1c1");
        v1.AddComment(v1c1);
        Comment v1c2 = new Comment("commenter v1c2", "Comment v1c2");
        v1.AddComment(v1c2);
        Comment v1c3 = new Comment("commenter v1c3", "Comment v1c3");
        v1.AddComment(v1c3);
        Comment v1c4 = new Comment("commenter v1c4", "Comment v1c4");
        v1.AddComment(v1c4);
        videos.Add(v1);

        // Name and create 2nd 'Video' instance
        Video v2 = new Video("test Name2", "Test Author2", 222);
        Comment v2c1 = new Comment("commenter v2c1", "Comment v2c1");
        v2.AddComment(v2c1);
        Comment v2c2 = new Comment("commenter v2c2", "Comment v2c2");
        v2.AddComment(v2c2);
        Comment v2c3 = new Comment("commenter v2c3", "Comment v2c3");
        v2.AddComment(v2c3);
        Comment v2c4 = new Comment("commenter v2c4", "Comment v2c4");
        v2.AddComment(v2c4);
        videos.Add(v2);

        // Name and create 3rd 'Video' instance
        Video v3 = new Video("test Name3", "Test Author3", 333);
        Comment v3c1 = new Comment("commenter v3c1", "Comment v3c1");
        v3.AddComment(v3c1);
        Comment v3c2 = new Comment("commenter v3c2", "Comment v3c2");
        v3.AddComment(v3c2);
        Comment v3c3 = new Comment("commenter v3c3", "Comment v3c3");
        v3.AddComment(v3c3);
        Comment v3c4 = new Comment("commenter v3c4", "Comment v3c4");
        v3.AddComment(v3c4);
        videos.Add(v3);

        // Name and create 4th 'Video' instance
        Video v4 = new Video("test Name4", "Test Author4", 444);
        Comment v4c1 = new Comment("commenter v4c1", "Comment v4c1");
        v4.AddComment(v4c1);
        Comment v4c2 = new Comment("commenter v4c2", "Comment v4c2");
        v4.AddComment(v4c2);
        Comment v4c3 = new Comment("commenter v4c3", "Comment v4c3");
        v4.AddComment(v4c3);
        Comment v4c4 = new Comment("commenter v4c4", "Comment v4c4");
        v4.AddComment(v4c4);
        videos.Add(v4);

        foreach (Video y in videos)
        {
            Console.WriteLine($"\nTitle: {y.GetTitle()}\nAuthor: {y.GetAuthor()}\nLength of Video (in seconds): {y.GetLength()}\nTotal Number of Comments: {y.NumberOfComments()}");
            foreach (Comment x in y.GetComments())
            {
                Console.WriteLine(x.GetDisplayText());
            }
        }
    }
}
// End Program.cs