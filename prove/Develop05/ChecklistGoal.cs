class ChecklistGoal : Goal
{
    // Variables
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    private DateTime _endTime;

    // Constructors
    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amount, DateTime startTime) : base(name, description, points, startTime)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
    }
    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amount, DateTime startTime, DateTime endTime) : base(name, description, points, startTime)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amount;
        _endTime = endTime;
    }

    // Getters/Setters
    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points + GetBonus();
        }
        return _points;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetAmountComplete()
    {
        return _amountCompleted;
    }

    // Methods
    public override void RecordEvent()
    {
        _amountCompleted ++;

        if (_amountCompleted == _target)
        {
            _endTime = DateTime.Now;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[X] {GetName()}: ({GetDescription()} - Start Time: {GetStartTime()}, Time Complete: {_endTime})";
        }

        return $"[ ] {GetName()}: ({GetDescription()} - Start Time: {GetStartTime()}) - {GetAmountComplete()}/{GetTarget()}";
    }

    public override string GetStringRepresentation()
    {
        return $"3::{GetName()}],[{GetDescription()}],[{GetPoints()}],[{GetBonus()}],[{GetTarget()}],[{GetAmountComplete()}],[{GetStartTime()}],[{_endTime}";
    }
}
