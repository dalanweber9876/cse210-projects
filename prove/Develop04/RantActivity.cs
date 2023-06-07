public class RantingActivity: Activity
{
    public RantingActivity(string activityName, string description): base(activityName, description)
    {

    }

    public void RunActivity()
    {
         int duration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        PauseWithSpinner(4);
        
        Console.WriteLine("What has been on your mind?");
        Console.Write("You may begin in: ");
        PauseWithTimer(4);
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (currentTime < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}