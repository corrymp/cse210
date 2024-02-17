class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address, "Reception")
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $"{GetTitle()}: {GetDescription()} RSVP: {_email} - {GetDate()} {GetTime()}, {GetAddress()}";
    }
}