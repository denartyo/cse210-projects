
 using System;

 class Program
 {
     static void Main(string[] args)
     {
         Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
         List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("Learn C# in One Hour", "TechGuru", 3600);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "I love the explanations.");
        video1.AddComment("Charlie", "Can you make one on C++?");
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("Mastering OOP in C#", "CodeMaster", 1800);
        video2.AddComment("David", "Very clear examples!");
        video2.AddComment("Emma", "Helped me a lot, thanks!");
        video2.AddComment("Frank", "I finally understand OOP!");
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("Debugging Tips & Tricks", "DevInsight", 2400);
        video3.AddComment("Grace", "This saved me hours of work!");
        video3.AddComment("Henry", "I need more content like this.");
        video3.AddComment("Ivy", "Awesome breakdown of debugging.");
        videos.Add(video3);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}


