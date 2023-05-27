using System;

public class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs",3,5,6);
        Scripture s1 = new Scripture(r1.GetReference(),"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.Clear();

        
        s1.DisplayScripture();
        while(true){
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to end the program:");
            string entry = Console.ReadLine();
            if (entry == "quit")
            {
                break;
            }

            else if (s1.IsCompletelyHidden() == true)
            {
                break;
            }
            
            else
            {
                Console.Clear();
                s1.HideWords();
                s1.DisplayScripture();
            }
            
        }
    }
}