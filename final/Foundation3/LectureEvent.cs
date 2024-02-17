class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"\"{GetTitle()}: {GetDescription()}\" by {_speaker}. [{_capacity} seats available] - {GetDate()} {GetTime()}, {GetAddress()}";
    }
}