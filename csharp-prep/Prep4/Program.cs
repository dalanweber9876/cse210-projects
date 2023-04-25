using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int number = -1;
        int sum = 0;
        int amount = -1;
        int largest = 0;
        
        List<int> numbers = new List<int>();
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);
            numbers.Add(number);

        }
        foreach (int item in numbers)
        {
            sum += item;
            amount += 1;
            if (item > largest)
            {
                largest = item;
            }
        }
        float average = (float)sum / amount;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}