public class EternalGoal: Goal
{
    public EternalGoal()
    {

    }
    public EternalGoal(string name, string description, int amountOfPoints): base(name, description, amountOfPoints)
    {

    }

    public override string GetGoalString() 
    {
        return ($"EternalGoal#:{_name}#:{_description}#:{_amountOfPoints}");

    }

    public override string IsComplete(int first, int second)
    {
        return " ";
    }

    public override int RecordEvent()
    {
        return _amountOfPoints;
    }
}