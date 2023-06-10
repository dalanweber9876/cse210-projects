using System;
using System.Diagnostics;

public class ListingActivity: Activity
{
    private string _prompt;
    private int _numberOfEntries;

    public ListingActivity(string activityName, string description): base(activityName, description)
        {

        }
    
    public void RunActivity()
    {
        _userInputDuration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        PauseWithSpinner(4);

        GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompt} ---");
        Console.Write("You may begin in: ");
        PauseWithTimer(4);
        Console.WriteLine();
        run(_userInputDuration);
        //List<string> entries = new List<string>();
        // DateTime startTime = DateTime.Now;
        // DateTime currentTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(_userInputDuration);
        // while (currentTime < futureTime)
        // {
        //    Console.Write(">");
        //    string entry = Console.ReadLine();
        //    entries.Add(entry);
        //    currentTime = DateTime.Now;

        // }

        //GetNumberOfEntries(entries);
        //Console.Write($"You listed {_numberOfEntries} items!");
        Console.WriteLine();
        Console.WriteLine();
    }
    private Stopwatch sw = new Stopwatch();
    private double lastFrame;
    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalMilliseconds;
        return dt;
    }

    public void run(int duration)
    {
        this.sw.Start();
        double acc = 0.0;
        int enterCount = 0;
        List<string> buf = new List<string>();
        Console.WriteLine("Go!");
        Console.Write(">");
        while (acc <= (duration * 1000))
        {
            acc += this.deltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                Console.Write(">");
                buf.Add("\n");
                enterCount += 1;
            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        }
        _numberOfEntries = enterCount;
        Console.WriteLine("\nTime's up!");
        string bufStr = String.Join<string>("", buf);
        Console.Write($"You listed {_numberOfEntries} items!");
    }
    
    private void GetRandomPrompt()
    {
        List<string> prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
        Random randomNumber = new Random();
        int randomPrompt = randomNumber.Next(0,5);
        _prompt = prompts[randomPrompt];
    }

    // private void GetNumberOfEntries(List<string>_entries)
    // {
    //     int count = 0;
    //     foreach(string item in _entries)
    //     {
    //         count += 1;
    //     }
    //     _numberOfEntries = count;
    // }
}