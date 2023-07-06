using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();
        //Video #1
        Video v1 = new Video("How to change the oil in a car", "Dan Weber", 512);
        Comment v1c1 = new Comment("Bill", "Thank you for the great tutorial!");
        Comment v1c2 = new Comment("Steve", "I couldn't have taught it better myself!");
        Comment v1c3 = new Comment("Chleo", "I can finally say that I know how to change the oil! Great tutorial!");
        v1.AddComment(v1c1);
        v1.AddComment(v1c2);
        v1.AddComment(v1c3);
        videos.Add(v1);

        //Video #2
        Video v2 = new Video("Why you shouldn't run from a bear", "Idaho Fish and Game", 1050);
        Comment v2c1 = new Comment("Shirley", "I can't believe that grizzly bears can run up to 35 miles/hour!");
        Comment v2c2 = new Comment("Robert", "My Grandpa ran from a grizzly bear and lived to tell the tale, they aren't that dangerous!");
        Comment v2c3 = new Comment("Stewart", "That is super scary. How likely am I to see a grizzly bear while hiking the Tetons?");
        Comment v2c4 = new Comment("Phil", "Bears aren't even real. They are just some story made up by mothers to keep their kids from playing in the woods. Don't fall for it!");
        v2.AddComment(v2c1);
        v2.AddComment(v2c2);
        v2.AddComment(v2c3);
        v2.AddComment(v2c4);
        videos.Add(v2);

        //Video #3
        Video v3 = new Video("How many bananas do you need to eat to die by radiation poisoning?", "Doctor Heinz Doofenshmirtz", 249);
        Comment v3c1 = new Comment("Julian", "My new mission in life is to eat 10,000,000 bananas at once so that I can tell people in heaven that I died by radiation poisoning from bananas");
        Comment v3c2 = new Comment("Cecilia", "Don't ask me why I am watching this at 2 AM when I should be sleeping");
        Comment v3c3 = new Comment("Clarissa", "I've been giving my 3 year old bananas almost everday for the past eight months. Do I need to take him to the doctor??");
        v3.AddComment(v3c1);
        v3.AddComment(v3c2);
        v3.AddComment(v3c3);
        videos.Add(v3);

        //Video #4
        Video v4 = new Video("How to potty train your puppy", "Mr. Peabody", 381);
        Comment v4c1 = new Comment("Gloria", "That sounds like a lot of work. I'll just tell my kids he got through the fence and that we can't find him.");
        Comment v4c2 = new Comment("Ginger", "Thank you so much for the help! I am beyond tired of my boyrfriend's dog peeing on the carpet all the time.");
        Comment v4c3 = new Comment("Chloe", "How long does the process take from start to finish?");
        Comment v4c4 = new Comment("George", "This is the exact reason why I refuse to have an indoor dog. Just build them a nice dog house and you never have to worry about them making a mess in the house.");
        v4.AddComment(v4c1);
        v4.AddComment(v4c2);
        v4.AddComment(v4c3);
        v4.AddComment(v4c4);
        videos.Add(v4);



        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentFormat());
            }
            Console.WriteLine();
        }
    }
}