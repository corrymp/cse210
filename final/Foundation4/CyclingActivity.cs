class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double duration, double speed) : base(date, duration)
    {
        SetActivity("Cycling");
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetDistance()
    {
        return GetSpeed() / GetDuration() * 60;
    }
}