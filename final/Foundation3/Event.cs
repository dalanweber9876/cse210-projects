public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event (string eventType, string eventTitle, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_eventTitle}: {_description}\n{_date} at {_time}\n{_address.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return "";
    }

    public string GetShortDescription()
    {
        return $"{_eventType} - {_eventTitle} - {_date}";
    }

}