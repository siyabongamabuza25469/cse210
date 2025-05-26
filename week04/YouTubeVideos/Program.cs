using System;
using System.Collections.Generic;
using System.Dynamic;

namespace YouTubeVideosProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

            
            Video video1 = new Video { Title = "Video 1", Author = "Author 1", Length = 120 };
            Video video2 = new Video { Title = "Video 2", Author = "Author 2", Length = 180 };
            Video video3 = new Video { Title = "Video 3", Author = "Author 3", Length = 150 };

            
            video1.AddComments(new Comment { CommenterName = "UserA", Text = "Great video!" });
            video1.AddComments(new Comment { CommenterName = "UserB", Text = "Interesting content." });
            video1.AddComments(new Comment { CommenterName = "UserC", Text = "I learn a lot." });

            video2.AddComments(new Comment { CommenterName = "ViewerX", Text = "Nice job!" });
            video2.AddComments(new Comment { CommenterName = "ViewerY", Text = "Liked the examples." });

            video3.AddComments(new Comment { CommenterName = "Person1", Text = "Well explained." });
            video3.AddComments(new Comment { CommenterName = "Person2", Text = "Informative." });

            
            Console.WriteLine("Video Information:");
            Console.WriteLine($"Title: {video1.Title}");
            Console.WriteLine($"Author: {video1.Author}");
            Console.WriteLine($"Length: {video1.Length} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in video1.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();

            Console.WriteLine("Video Information:");
            Console.WriteLine($"Title: {video2.Title}");
            Console.WriteLine($"Author: {video2.Author}");
            Console.WriteLine($"Length: {video2.Length} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in video2.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();

            Console.WriteLine("Video Information:");
            Console.WriteLine($"Title: {video3.Title}");
            Console.WriteLine($"Author: {video3.Author}");
            Console.WriteLine($"Length: {video3.Length} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in video3.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }
    }

    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        private List<Comment> comments = new List<Comment>();
        public void AddComments(Comment comment)
        {
            comments.Add(comment);
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }

    public class Comment
    {
        public string CommenterName { get; set; }
        public string Text { get; set; }
    }
}
