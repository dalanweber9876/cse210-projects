using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> eventList = new List<Event>();
        //Lecture
        Address e1a = new Address("1923 Minturn St", "Alameda", "CA", "USA");
        Lecture e1 = new Lecture("Lecture", "Ted Talk", "A Ted Talk about the dangers of Social Media", "12/15/23", "2-4PM", e1a, "Barry Allen", 250);
        eventList.Add(e1);

        //Reception
        Address e2a = new Address("1027 Kane Concourse", "Bay Harbor Islands", "FL", "USA");
        Reception e2 = new Reception("Reception", "Mr and Mrs White's Reception", "The reception for the the newly wed Mr and Mrs White", "11/2/23", "1-4PM", e2a, "benandbettywhite@gmail.com");
        eventList.Add(e2);

        //Outdoor Gathering
        Address e3a = new Address("2817 Del Rio Pl #11", "Louisville", "KY", "USA");
        OutdoorGathering e3 = new OutdoorGathering("Outdoor Gathering", "Smith Family Reunion", "Family reunion for the Smith family", "09/7/23 - 09/10/23", "8:00AM", e3a, "Should be sunny all weekend with a slight chance of rain on Saturday");
        eventList.Add(e3);

        Console.Clear();
        Console.WriteLine();
        foreach(Event singleEvent in eventList)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(singleEvent.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(singleEvent.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(singleEvent.GetShortDescription());
            Console.WriteLine("\n");
        }
    }
}