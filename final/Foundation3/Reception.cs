public class Reception: Event
{
    private string _email;

    public Reception (string eventType, string eventTitle, string description, string date, string time, Address address, string email): base(eventType, eventTitle, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nReception - RSVP at {_email}";
    }
}