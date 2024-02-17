class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, double duration, int laps) : base(date, duration)
    {
        SetActivity("Swimming");
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
}