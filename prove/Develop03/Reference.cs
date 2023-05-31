public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

    public Reference (string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }

    public Reference (string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }



    public string GetReference ()
    {
        string reference = ($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        return reference;
    }

    public string LivingChristReference()
    {
        string reference = ($"{_book} paragraph {_firstVerse}");
        return reference;
    }
}