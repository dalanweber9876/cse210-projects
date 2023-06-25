public class ChecklistGoal: Goal
{
    private int _bonusPoints;
    private int _timesCompleted;
    private int _timesForBonus;
    

    public ChecklistGoal()
    {

    }
    public ChecklistGoal(string name, string description, int amountOfPoints, int bonusPoints, int timesForBonus, int timesCompleted): base(name, description, amountOfPoints)
    {
        _bonusPoints = bonusPoints;
        _timesForBonus = timesForBonus;
        _timesCompleted = timesCompleted;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
        
        // Get timesForBonus value
        Console.Write("How many times does this goal need to be accomplished for a bonus?");
        string timesForBonusString = Console.ReadLine();
        _timesForBonus = int.Parse(timesForBonusString);

        // Points for bonus times accomplished
        Console.Write("What is the bonus for accomplishing it that many times?");
        string bonusPointsString = Console.ReadLine();
        _bonusPoints = int.Parse(bonusPointsString);        
    }

    public override string GetGoalString()
    {
        return ($"ChecklistGoal#:{_name}#:{_description}#:{_amountOfPoints}#:{_bonusPoints}#:{_timesForBonus}#:{_timesCompleted}");
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _timesForBonus)
        {    
            _timesCompleted += 1;
            if(_timesCompleted == _timesForBonus)
            {
                return _amountOfPoints + _bonusPoints;
            }
            else
            {
                return _amountOfPoints;
            }
        }

        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }

        
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
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
}