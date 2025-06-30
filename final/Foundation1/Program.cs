using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("A million days in Minecraft", "Mining Alice", 5400);
        Video video2 = new Video("The significance of insignificance", "Thinking Too Deeply", 1200);
        Video video3 = new Video("C# is Fun... sometimes", "CRANKY", 280);
        Video video4 = new Video("Jimmy Nuetron was right all along", "Tj MIN", 600);

        // Add comments to video1
        video1.AddComment(new Comment("The fact that this is realllll", "CaptainSparklez"));
        video1.AddComment(new Comment("I want to be in this next time!", "EmelyYT"));
        video1.AddComment(new Comment("When Drex called you out LOL!!!!", "Maximillian"));

        // Add comments to video2
        video2.AddComment(new Comment("This really clarified things for me.", "JamminSophie"));
        video2.AddComment(new Comment("Loved the real world examples!", "LiamTechTips"));
        video2.AddComment(new Comment("Subbed and liked!", "RisingStar"));

        // Add comments to video3
        video3.AddComment(new Comment("I still struggle with interfaces, but this helped.", "Noah"));
        video3.AddComment(new Comment("Perfect timing for my class!", "OliviaOLIVE"));
        video3.AddComment(new Comment("I think it's never fun :)", "Etn"));

        // Add comments to video4
        video4.AddComment(new Comment("Great explanation!!!!!!!!!!!!!!!!!!!!!!!!!!", "Isabella"));
        video4.AddComment(new Comment("Nice animations!", "Jack"));
        video4.AddComment(new Comment("This made it click. Thanks!", "Ava"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display each video and its comments
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine(); // Add a line break between videos
        }
    }
}
