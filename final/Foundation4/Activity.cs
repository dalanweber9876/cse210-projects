public class Activity
{
    private string _date;
    protected double _duration;
    private string _activity;

    public Activity(string activity, string date, double duration)
    {
        _activity = activity;
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {_activity} ({_duration} min) - Distance {Math.Round(GetDistance(), 1)} miles, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile";
    }
}