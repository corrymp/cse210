abstract class Goal
{
    // Variables
    private string _shortName;
    private string _description;
    protected int _points;
    private DateTime _startTime;

    // Constructors
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _startTime = DateTime.Now;
    }
    public Goal(string name, string description, int points, DateTime startTime)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _startTime = startTime;
    }

    // Getters/Setters
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public DateTime GetStartTime()
    {
        return _startTime;
    }

    // Methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string done;

        if (IsComplete() == true)
        {
            done = "[X]";
        }

        else
        {
            done = "[ ]";
        }

        return $"{done} {GetName()}: ({GetDescription()})";
    }
}