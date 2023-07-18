using System;
using System.IO;
class Program
{
    static void Main()
    {
        List<Entry> entries = new List<Entry>();
        Journal journal = new Journal(entries);
        
        string userSelection = "";
        Console.Clear();
        Console.WriteLine("\nWelcome to the Journal Program!");

        while (userSelection != "6")
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Motivation\n6. Quit");
            Console.Write("What would you like to do?");
            userSelection = Console.ReadLine();
            Console.Clear();

            if (userSelection == "1")
            {
                journal.AddEntry(entries);
            }
            
            else if (userSelection == "2")
            {
                journal.DisplayEntries(entries);
            }

            else if (userSelection == "3")
            {     
                journal.LoadFromFile(entries); 
            }

            else if (userSelection == "4")
            {
                journal.SaveToFile(entries); 
            }

            else if (userSelection == "5")
            {
                Motivation quote = new Motivation();
                string motivationalQuote = quote.randomMotivation();
                Console.WriteLine($"\n{motivationalQuote}\n");
            }

            else if (userSelection == "6")
            {
                Console.Write("Have a nice day!\n");
            }

            else
            {
                Console.WriteLine("Invalid entry. Please enter a number 1-6");
            }
        } 
    }
}