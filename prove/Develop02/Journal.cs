public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public Journal(List<Entry> entries)
    {
        _entries = entries;
    }

    public void AddEntry(List<Entry> entries)
    {
        //prompt
        Prompt rp = new Prompt();
        string prompt = rp.RandomPrompt();
        Console.WriteLine(prompt);

        //response
        Console.Write(">");
        string response = Console.ReadLine();

        //dateText
        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();

        Entry newEntry = new Entry(dateText, prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayEntries(List<Entry> entries)
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.newEntry());
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        Console.Write("What is the file name?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine("");
            }
        foreach (Entry entry in entries)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.WriteLine($"Date: {entry.GetDate()} - {entry.GetPrompt()} \n{entry.GetResponse()}\n");
            }
        }
    }

    public void LoadFromFile(List<Entry> entries)
    {
        Console.Write("What is the file name?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        entries.Clear();
        string date = "";
        string prompt = "";
        string response = "";
        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            string[] isDate = line.Split(":");
            string[] getDate = line.Split(" ");
            
            if (isDate[0] == "Date")
            {
                date = getDate[1];
                prompt = parts[1];
            }
            else if (line != "")
            {
                response = line;
                Entry newEntry = new Entry(date, prompt, response);
                entries.Add(newEntry);
            }
            

            
        }  
        
    }
}