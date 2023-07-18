public class BreathingActivity: Activity
{
    private double _breatheInDuration;
    private double _breatheOutDuration;
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
            TimeSpan difference = futureTime - currentTime;
            double timeLeft = difference.TotalSeconds;
            if (timeLeft >= 10 )
            {
                _breatheInDuration = 5;
                _breatheOutDuration = 5;
            }
            else if (Math.Round(timeLeft, 0) == 2)
            {
                _breatheInDuration = Math.Round(timeLeft / 2, 1);
                _breatheOutDuration = Math.Round(timeLeft / 2, 1);
            }
            else if (Math.Round(timeLeft, 0) == 4)
            {
                _breatheInDuration = Math.Round(timeLeft / 2, 1);
                _breatheOutDuration = Math.Round(timeLeft / 2, 1);
            }
            else if (Math.Round(timeLeft, 0) == 6)
            {
                _breatheInDuration = Math.Round(timeLeft / 2, 1);
                _breatheOutDuration = Math.Round(timeLeft / 2, 1);
            }
            else if (Math.Round(timeLeft, 0) == 8)
            {
                _breatheInDuration = Math.Round(timeLeft / 2, 1);
                _breatheOutDuration = Math.Round(timeLeft / 2, 1);
            }
            else
            {
                _breatheInDuration = Math.Round(timeLeft / 2, 1) + .5;
                _breatheOutDuration = Math.Round(timeLeft / 2, 1) - .5;
            }
            
            BreatheIn();
            Console.WriteLine();
            BreatheOut();
            Console.WriteLine();
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}