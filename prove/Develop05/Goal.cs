public class Goal
{
    protected string _name;
    protected string _description;
    protected int _amountOfPoints;
    

    public Goal()
    {

    }
    public Goal (string name, string description, int amountOfPoints)
    {
        _name = name;
        _description = description;
        _amountOfPoints = amountOfPoints;
    }

    public virtual string IsComplete(int first, int second)
    {
        return " ";
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual void CreateGoal()
    {
        // Get the name of the goal
        Console.Write("What is the name of your goal?");
        _name = Console.ReadLine();

        // Get goal description
        Console.Write("What is a short description of your goal?");
        _description = Console.ReadLine();

        // Get points for the goal
        Console.Write("What is the amount of points associated with this goal?");
        string pointsString = Console.ReadLine();
        _amountOfPoints = int.Parse(pointsString);
    }

    public virtual string GetGoalString() 
    {
        return null;

    }

    
}