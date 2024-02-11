class SimpleGoal : Goal
{
    // Variables
    private bool _isComplete = false;
    private DateTime _endTime;

    // Contructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public SimpleGoal(string name, string description, int points, DateTime startTime, bool complete) : base(name, description, points, startTime)
    {
        _isComplete = complete;
    }

    public SimpleGoal(string name, string description, int points, DateTime startTime, bool complete, DateTime endTime) : base(name, description, points, startTime)
    {
        _isComplete = complete;
        _endTime = endTime;
    }

    // Methods
    public override void RecordEvent()
    {
        _isComplete = true;
        _endTime = DateTime.Now;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"1::{GetName()}],[{GetDescription()}],[{GetPoints()}],[{GetStartTime()}],[{IsComplete()}],[{_endTime}";
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {GetName()}: ({GetDescription()} - Start Time: {GetStartTime()}, Time Complete: {_endTime})";
        }

        return $"[ ] {GetName()}: ({GetDescription()} - Start Time: {GetStartTime()})";
    }
}