public class Lecture: Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture (string eventType, string eventTitle, string description, string date, string time, Address address, string speakerName, int capacity): base(eventType, eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nLecture - {_speakerName} - Maximum of {_capacity} people may attend";
    }
}