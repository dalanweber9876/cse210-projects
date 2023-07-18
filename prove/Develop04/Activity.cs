public class Activity
{
    private string _activityName;
    private string _description;
    protected int _userInputDuration;

    public Activity()
    {

    }
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n\nThis activity will help you {_description}");
    }

    public void DisplayGoodbyeMessage()
    {
        Console.WriteLine("Well done!!");
        
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_userInputDuration} seconds of the {_activityName}.");
        PauseWithSpinner(4);
        Console.Clear();
    }

    public int GetDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        _userInputDuration = durationInt;
        return durationInt;
    }

    public void PauseWithSpinner(double duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (currentTime < futureTime)
        {
            Console.Write("|");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("/"); 

            Thread.Sleep(250);

            Console.Write("\b \b"); 
            Console.Write("-"); 

            Thread.Sleep(250);

            Console.Write("\b \b"); 
            Console.Write("\\"); 
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            currentTime = DateTime.Now;
        }
    }

    public void PauseWithTimer(double duration)
    {
        int count = 0;
        while ( count < duration)
        {
            double current = duration - count;
            Console.Write(current);
            Thread.Sleep(1000);

            Console.Write("\b \b");
            count += 1;
        }
    }
}