public class ClearMindActivity: Activity
{
    public ClearMindActivity(string activityName, string description): base(activityName, description)
    {

    }

    public void RunActivity()
    {
        _userInputDuration = GetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
        PauseWithSpinner(4);
        
        Console.WriteLine("Prepare to let go of everything that has been on your mind");
        Console.Write("You may begin in: ");
        PauseWithTimer(4);
        Console.WriteLine();

        // DateTime startTime = DateTime.Now;
        // DateTime currentTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(_userInputDuration);
        // while (currentTime < futureTime)
        // {
        //     Console.Write(">");
        //     Console.ReadLine();
        //     currentTime = DateTime.Now;
        // }
        // Console.WriteLine();
        // Console.WriteLine();

        int count = 0;
        while ( count < _userInputDuration)
        {
            double current = _userInputDuration - count;
            Console.Write(current);
            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            count += 1;
        }
    }
}