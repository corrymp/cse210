class EternalGoal : Goal
{
    // Variables
    private int _timesDone = 0;

    // Constructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    
    public EternalGoal(string name, string description, int points, DateTime startTime, int timesDone) : base(name, description, points, startTime)
    {
        _timesDone = timesDone;
    }

    public int GetTimesDone()
    {
        return _timesDone;
    }

    // Methods
    public override void RecordEvent()
    {
        _timesDone ++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"2::{GetName()}],[{GetDescription()}],[{GetPoints()}],[{GetStartTime()}],[{GetTimesDone()}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()}: ({GetDescription()} - Start: {GetStartTime()}, Times Done: {GetTimesDone()})";
    }
}