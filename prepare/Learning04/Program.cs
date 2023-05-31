using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Steven King", "English");
        Console.WriteLine();
        Console.WriteLine(a1.GetSummary());

        MathAssignment ma1 = new MathAssignment("Billy Joel", "Math", "23.6", "1-33, 35, 38");
        Console.WriteLine();
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignment wa1 = new WritingAssignment("Frank Sinatra", "History", "The War of 1812");
        Console.WriteLine();
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInformation());
        Console.WriteLine();
    }
}