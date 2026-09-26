// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Name and create 1st 'Video' instance 
        Video v1 = new Video("\"10-Minute Home Workout\"", "FitLife Coach", 612);
        Comment v1c1 = new Comment("Taylor S.", "\"Never knew it was this simple, thank you!\"");
        v1.AddComment(v1c1);
        Comment v1c2 = new Comment("Bailey Q.", "\"Tried this over the weekend and it worked perfectly.\"");
        v1.AddComment(v1c2);
        Comment v1c3 = new Comment("Skyler J.", "\"First time commenting — this really helped.\"");
        v1.AddComment(v1c3);
        videos.Add(v1);

        // Name and create 2nd 'Video' instance
        Video v2 = new Video("\"5 Tips for Better Sleep\"", "Wellness With Nora", 367);
        Comment v2c1 = new Comment("Omar H.", "\"Watched this right before bed, super calming explanation.\"");
        v2.AddComment(v2c1);
        Comment v2c2 = new Comment("Avery N.", "\"Bookmarking this for later.\"");
        v2.AddComment(v2c2);
        Comment v2c3 = new Comment("Blair E.", "\"Exactly what I was searching for.\"");
        v2.AddComment(v2c3);
        Comment v2c4 = new Comment("Alex K.", "\"Subscribed after this one video.\"");
        v2.AddComment(v2c4);
        videos.Add(v2);

        // Name and create 3rd 'Video' instance
        Video v3 = new Video("\"Learning Guitar Chords Fast\"", "Strum Along", 780);
        Comment v3c1 = new Comment("Jordan M.", "\"This was way more helpful than I expected!\"");
        v3.AddComment(v3c1);
        Comment v3c2 = new Comment("Quinn D.", "\"The visuals made this so much easier to follow.\"");
        v3.AddComment(v3c2);
        Comment v3c3 = new Comment("Rowan V.", "\"Great pacing, not too fast or slow.\"");
        v3.AddComment(v3c3);
        Comment v3c4 = new Comment("Sam T.", "\"Can you do a follow-up on this topic?\"");
        v3.AddComment(v3c4);
        Comment v3c5 = new Comment("Reese A.", "\"Would love a part 2 on this!\"");
        v3.AddComment(v3c5);
        videos.Add(v3);

        // Name and create 4th 'Video' instance 
        Video v4 = new Video("\"Beginner Piano: Your First Song\"", "Keys With Kayla", 540);
        Comment v4c1 = new Comment("Priya R.", "\"I've watched this three times now, great explanation.\"");
        v4.AddComment(v4c1);
        Comment v4c2 = new Comment("Devon L.", "\"The pacing was perfect for beginners.\"");
        v4.AddComment(v4c2);
        Comment v4c3 = new Comment("Riley P.", "\"Great production quality!\"");
        v4.AddComment(v4c3);
        Comment v4c4 = new Comment("Morgan B.", "\"Quick question — does this work for beginners too?\"");
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