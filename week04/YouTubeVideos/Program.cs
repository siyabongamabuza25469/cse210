using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        List<string> comments = new List<string>();
        
    // Comment class to track the name of the commenter and the text of the comment
    public class Comment
    {
    public string CommenterName { get; set; }
    public string CommentText { get; set; }
    }

       // Video class to track title, author, length, comments
       public class Video
       {
          public string Title { get; set; }
          public string Author { get; set; }
         public int LengthInSeconds { get; set; }
         public List Comments { get; set; }

         public Video(string title, string author, int length)
         {
         Title = title;
         Author = author;
         LengthInSeconds = length;
         Comments = new List();
         }

         public int GetNumberOfComments()
         {
        return Comments.Count;
         }
         }

         class Program
         {
         static void Main()
         {
             List



         }
     } 

    }

}



        
    
