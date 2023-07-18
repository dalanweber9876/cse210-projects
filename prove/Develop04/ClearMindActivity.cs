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