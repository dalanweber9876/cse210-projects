public class BreathingActivity: Activity
{
    private int _breatheInDuration = 5;
    private int _breatheOutDuration = 5;
    public BreathingActivity(string activityName, string description): base(activityName, description)
    {
        
    }

    public void BreatheIn()
    {
       Console.Write("Breathe in...");
       PauseWithTimer(_breatheInDuration);
    }
    public void BreatheOut()
    {
        Console.Write("Breathe out...");
        PauseWithTimer(_breatheOutDuration);
    }
    public void RunActivity()
    {
        _userInputDuration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        PauseWithSpinner(4);
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_userInputDuration);
        while (currentTime < futureTime)
        {
            BreatheIn();
            Console.WriteLine();
            BreatheOut();
            Console.WriteLine();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}