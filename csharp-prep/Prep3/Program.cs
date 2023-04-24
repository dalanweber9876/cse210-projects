using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            /*Console.Write("What is the Magic Number?");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);*/
            int guess = 0;
            int score = 0;

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            do{
                Console.Write("What is your guess?");
                string guessString = Console.ReadLine();
                guess = int.Parse(guessString);

            
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                }
                score += 1;
            } while (guess != number);
            Console.WriteLine($"You got it in {score} guesses!");
            Console.Write("Would you like to play again? (Enter 'yes' or 'no')");
            response = Console.ReadLine();
        }
    }
}