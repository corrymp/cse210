class GatheringEvent : Event
{
    private string _weather;

    public GatheringEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetTitle()}: {GetDescription()} - {GetDate()} {GetTime()} ({_weather} weather anticipated) - {GetAddress()}";
    }
}