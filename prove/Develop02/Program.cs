using System;
using System.IO;
class Program
{
    static void Main()
    {
        var list = new List<string>();
        string prompt = "";
        string response = "";
        string userSelection = "";
        Console.WriteLine("");
        Console.WriteLine("\nWelcome to the Journal Program!");

        while (userSelection != "6")
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Motivation\n6. Quit");
            Console.Write("What would you like to do?");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                Prompt randomPromptGenerator = new Prompt();
                prompt = randomPromptGenerator.randomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">");
                response = Console.ReadLine();
                Entry newEntry = new Entry();
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                newEntry._date = dateText;
                newEntry._prompt = prompt;
                newEntry._response = response;
                string variable = newEntry.newEntry();
                list.Add(variable);
            }
            
            else if (userSelection == "2")
            {
                foreach (string item in list)
                    Console.WriteLine(item);
            }

            else if (userSelection == "3")
            {
                Console.Write("What is the file name?");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                list.Clear();
                foreach (string line in lines)
                {
                    list.Add(line);
                }         
            }

            else if (userSelection == "4")
            {
                Console.Write("What is the file name?");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine("");
                    }
                foreach (string line in list)
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName, true))
                    {
                        outputFile.WriteLine(line);
                    }
                }
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
                Console.WriteLine("Invalid entry. Please enter a number 1-5");
            }
        } 
    }
}