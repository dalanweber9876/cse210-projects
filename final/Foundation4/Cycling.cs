public class Cycling: Activity
{
    private double _speed;

    public Cycling (string activity, string date, double duration, double speed): base(activity, date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _duration / GetPace();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}