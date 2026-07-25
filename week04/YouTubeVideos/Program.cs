using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("C# Basics Tutorial", "John Developer", 1245);
        video1.AddComment(new Comment("Sarah", "Great explanation! Really helped me understand classes."));
        video1.AddComment(new Comment("Mike", "The examples were super clear."));
        video1.AddComment(new Comment("Emma", "Finally I get abstraction!"));
        video1.AddComment(new Comment("David", "Please make more videos like this."));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Web Development with ASP.NET", "Alex Code", 2340);
        video2.AddComment(new Comment("Lisa", "This was exactly what I needed for my project."));
        video2.AddComment(new Comment("Chris", "The step-by-step approach is perfect for beginners."));
        video2.AddComment(new Comment("Anna", "Can't wait for the next part!"));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Debugging Tips and Tricks", "Tech Master", 945);
        video3.AddComment(new Comment("James", "Those debugging techniques just saved me hours."));
        video3.AddComment(new Comment("Rachel", "Never knew about that Visual Studio feature!"));
        video3.AddComment(new Comment("Tom", "Subscribed for more content like this."));
        video3.AddComment(new Comment("Sophie", "Bookmark this one for sure."));
        videos.Add(video3);

        // Create fourth video
        Video video4 = new Video("Object-Oriented Design Patterns", "Pattern Expert", 3100);
        video4.AddComment(new Comment("Kevin", "The real-world examples made it so easy to understand."));
        video4.AddComment(new Comment("Nina", "I'm using this in my current project!"));
        video4.AddComment(new Comment("Ryan", "Best explanation of design patterns I've seen."));
        videos.Add(video4);

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Comments:");

            List<Comment> comments = video.GetComments();
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }
        }

        Console.WriteLine();
        Console.WriteLine("==================================================");
    }
}
