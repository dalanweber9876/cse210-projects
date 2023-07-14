using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running r = new Running("Running", "12-28-20", 36, 4);
        activities.Add(r);

        Cycling c = new Cycling("Cycling", "09-07-20", 65, 10);
        activities.Add(c);

        Swimming s = new Swimming("Swimming", "07-16-22", 45, 36);
        activities.Add(s);


        Console.Clear();
        foreach (Activity newActivity in activities)
        {
            Console.WriteLine(newActivity.GetSummary());
            Console.WriteLine();
        }

    }
}