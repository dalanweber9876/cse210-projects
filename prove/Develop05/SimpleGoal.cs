public class SimpleGoal: Goal
{
    public SimpleGoal()
    {

    }
    public SimpleGoal(string name, string description, int amountOfPoints): base(name, description, amountOfPoints)
    {

    }

    public override string IsComplete(int first, int second)
    {
        if (first >= second)
        {
            return "x";
        }
        else
        {
            return " ";
        }
    }

    public override int RecordEvent()
    {
        return _amountOfPoints;
    }

    public override string GetGoalString() 
    {
        return ($"SimpleGoal#:{_name}#:{_description}#:{_amountOfPoints}#:0");

    }
}