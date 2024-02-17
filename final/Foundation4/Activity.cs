abstract class Activity
{
    private string _type;
    private string _date;
    private double _duration;

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public void SetActivity(string type)
    {
        _type = type;
    }

    public string GetActivity()
    {
        return _type;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return 60 / GetPace();
    }

    public virtual double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public string GetSummary()
    {
        return $"{_date} {GetActivity()} ({GetDuration()} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}