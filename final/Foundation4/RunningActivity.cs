class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double duration, double distance) : base(date, duration)
    {
        SetActivity("Running");
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}