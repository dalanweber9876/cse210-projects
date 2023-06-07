using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string userInput = "";
        while (userInput != "5")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Ranting Activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu:");
            userInput = Console.ReadLine();

            Activity a = new Activity();

            if (userInput == "1")
            {
                BreathingActivity ba = new BreathingActivity("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                ba.DisplayWelcomeMessage();
                ba.RunActivity();
                ba.DisplayGoodbyeMessage();
            }

            else if (userInput == "2")
            {
                ReflectionActivity ra = new ReflectionActivity("Reflection Activity", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                ra.DisplayWelcomeMessage();
                ra.RunActivity();
                ra.DisplayGoodbyeMessage();
            }

            else if (userInput == "3")
            {
                ListingActivity la = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                la.DisplayWelcomeMessage();
                la.RunActivity();
                la.DisplayGoodbyeMessage();
            }

            else if (userInput == "4")
            {
                RantingActivity ra = new RantingActivity("Ranting Activity", "get things off your chest by having you write down whatever you would like to say.");
                ra.DisplayWelcomeMessage();
                ra.RunActivity();
                ra.DisplayGoodbyeMessage();
            }

            else if (userInput == "5"){}

            else
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine("Please enter a menu item (1-5)");
            }

        }
    }
}