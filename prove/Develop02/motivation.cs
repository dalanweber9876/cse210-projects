public class Motivation
{
    public string _randomMotivationGenerator;
    string[] motivationQuotes = {"There are exactly as many special occasions in life as we choose to celebrate.", "Success is liking yourself, liking what you do, and liking how you do it.", "Say yes and you will figure it out afterward.", "There is no greater thing you can do with your life and your work than follow your passions - in a way that serves the world and you.", "The grass is greener where you water it.", "The secret of getting ahead is getting started."};
    public string randomMotivation()
    {
        Random random = new Random();
        int number = random.Next(0,6);
        //Console.WriteLine(motivationQuotes[number]);
        return motivationQuotes[number];
    }
}