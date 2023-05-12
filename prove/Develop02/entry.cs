public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string newEntry()
    {
        string completedEntry = ($"Date: {_date} - {_prompt}\n{_response}\n");
        return completedEntry;   
    }
}