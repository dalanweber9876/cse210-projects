public class Swimming: Activity
{
    private double _numberOfLaps;

    public Swimming(string activity, string date, double duration, double numberOfLaps): base(activity, date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * .62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}