abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string GetTitle()
    {
        return _title;
    }
    
    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public string GetEventType()
    {
        return _type;
    }

    public string GetDetails()
    {
        return $"{_title}: {_description} - {_date} {_time}, {_address.GetAddress()}";
    }
    
    public string GetSummary()
    {
        return $"{_type}: {_title} - {_date}";
    }

    public abstract string GetFullDetails();
}