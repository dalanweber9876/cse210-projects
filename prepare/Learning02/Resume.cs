public class resume
{
    public string _personName;
    public List<job> _jobs = new List<job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}