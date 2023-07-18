public class Prompt
{
    string[] prompts = {"What was your biggest challenge today?", "What was your biggest success today?", "What are you thankful for today?", "What is one thing that you want to improve tomorrow?", "What is a childhood memory that you don't want to forget?", "How did you see God in your life today?"};
    public string RandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0,6);
        return prompts[number];
    }
}