public class Prompt
{
    public string _randomPromptGenerator;
    string[] prompts = {"What was your biggest challenge today?", "What was your biggest success today?", "What are you thankful for today?", "What is one thing that you want to improve tomorrow?", "What is a childhood memory that you don't want to forget?", "How did you see God in your life today?"};
    public string randomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0,6);
        //Console.WriteLine(prompts[number]);
        return prompts[number];
    }
}