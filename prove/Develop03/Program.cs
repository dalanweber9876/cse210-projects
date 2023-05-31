using System;

public class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("The Living Christ",0,2,2);
        Scripture s1 = new Scripture(r1.LivingChristReference(), "He was the Great Jehovah of the Old Testament, the Messiah of the New. Under the direction of His Father, He was the creator of the earth. 'All things were made by him; and without him was not any thing made that was made.' Though sinless, He was baptized to fulfill all righteousness. He 'went about doing good,' yet was despised for it. His gospel was a message of peace and goodwill. He entreated all to follow His example. He walked the roads of Palestine, healing the sick, causing the blind to see, and raising the dead. He taught the truths of eternity, the reality of our premortal existence, the purpose of our life on earth, and the potential for the sons and daughters of God in the life to come.");

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