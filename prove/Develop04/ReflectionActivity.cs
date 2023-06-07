
public class ReflectionActivity: Activity
{
    private string _prompt;
    private string _question;
    public ReflectionActivity(string activityName, string description): base(activityName, description)
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
        
        Console.WriteLine("\nConsider the Following Prompt:\n");
        Console.WriteLine($" --- {_prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseWithTimer(4);
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_userInputDuration);
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            GetRandomQuestions();
            Console.Write($"> {_question}");
            PauseWithSpinner(10);
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine();

    }

    private void GetRandomPrompt()
    {
        List<string> prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        Random randomNumber = new Random();
        int randomPrompt = randomNumber.Next(0,4);
        _prompt = prompts[randomPrompt];
    }

    private void GetRandomQuestions()
    {
        List<string> questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
        Random randomNumber = new Random();
        int randomQuestion = randomNumber.Next(0,9);

        _question = questions[randomQuestion];
    }
}