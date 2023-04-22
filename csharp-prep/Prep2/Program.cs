using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string percentageInText = Console.ReadLine();
        int percentage = int.Parse(percentageInText);
        string letter = "";
        
        if (percentage >= 90)
        {
            //Console.WriteLine("You have an A");
            letter = "A";
        }
        else if (percentage >= 80)
        {
            //Console.WriteLine("You have a B");
            letter = "B";
        }
        else if (percentage >= 70)
        {
            //Console.WriteLine("You have a C");
            letter = "C";
        }
        else if (percentage >= 60)
        {
            //Console.WriteLine("You have a D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("You have an F");
            letter = "F";
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"You have an {letter}!");
        }
        else
        {
            Console.WriteLine($"You have a {letter}!");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congrats on passing the class!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}