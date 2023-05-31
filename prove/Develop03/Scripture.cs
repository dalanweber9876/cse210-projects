public class Scripture
{
    private string _reference;
    private string _text;
    private List<Word> _scripture;
    private List<int> selections = new List<int>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _scripture = GetRenderedText(text);
    }

    public string GetScripture()
    {
        string scripture = ($"{_reference}: {_text}");
        return scripture;
    }
    
    public void HideWords()
    {
        int count = 0;
        while (count < 1)
        {
            Random random = new Random();
            int number = random.Next(_scripture.Count());
            while (selections.Contains(number))
            {
                number = random.Next(_scripture.Count());
            }
            _scripture[number].HideWord();
            selections.Add(number);
            count += 1;
        }
    }

    public void DisplayScripture()
    {
        Console.Write($"{_reference}: ");
        foreach (Word word in _scripture)
        {
            word.Display();
        }
    }
    
    public List<Word> GetRenderedText(string text)
    {

        List<Word> textString = new List<Word>();
        string[] pieces = text.Split(" ");
        foreach (string piece in pieces)
        {
            textString.Add(new Word($"{piece}"));
        }
        return textString;
    }

    public bool IsCompletelyHidden()
    {
        if (selections.Count() ==  _scripture.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}