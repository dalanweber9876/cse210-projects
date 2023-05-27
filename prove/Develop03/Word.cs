public class Word
{
    private string _word;
    private bool _hidden = false;

    public Word (string word)
    {
        _word = word;
    }

    public void Display(){
        if (_hidden){
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else{
            Console.Write($"{_word} ");
        }
    }

    public void HideWord(){
        _hidden = true;
    }
    
}