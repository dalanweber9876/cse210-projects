using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string selection = "";
        List<string> entries = new List<string>();
        int currentPoints = 0;
        
        while (true)
        {
            
            //Console.Clear();
            Goal g = new Goal();
            Console.WriteLine($"\nYou have {currentPoints} points.\n");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Delete Goal\n  7. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = Console.ReadLine();

            if (selection == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();
                if (goalType == "1")
                {
                    SimpleGoal sg = new SimpleGoal();
                    sg.CreateGoal();
                    entries.Add(sg.GetGoalString());
                }

                else if (goalType == "2")
                {
                    EternalGoal eg = new EternalGoal();
                    eg.CreateGoal();
                    entries.Add(eg.GetGoalString());
                }

                else if (goalType == "3")
                {
                    ChecklistGoal cg = new ChecklistGoal();
                    cg.CreateGoal();
                    entries.Add(cg.GetGoalString());
                }
            }

            else if (selection == "2")
            {
                Console.WriteLine("\nThe goals are:");
                int count = 1;
                foreach(string entry in entries)
                {
                    string[] pieces = entry.Split("#:");
                    if(pieces[0] == "SimpleGoal")
                    {   
                        SimpleGoal sg = new SimpleGoal();
                        Console.WriteLine($"{count}. [{sg.IsComplete(int.Parse(pieces[4]), 1)}] {pieces[1]} ({pieces[2]})");
                        count += 1;
                    }
                    else if(pieces[0] == "EternalGoal")
                    {
                        Console.WriteLine($"{count}. [ ] {pieces[1]} ({pieces[2]})");
                        count += 1;
                    }

                    else if(pieces[0] == "ChecklistGoal")
                    {
                        ChecklistGoal cg = new ChecklistGoal();
                        Console.WriteLine($"{count}. [{cg.IsComplete(int.Parse(pieces[6]), int.Parse(pieces[5]))}] {pieces[1]} ({pieces[2]}) -- Currently completed: {int.Parse(pieces[6])}/{pieces[5]}");
                        count += 1;
                    }
                }
            }

            else if (selection == "3")
            {
                Console.Write("What is the filename for the goal file?");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(currentPoints);
                    foreach(string entry in entries)
                    {
                        outputFile.WriteLine(entry);
                    }
                }

            }

            else if (selection == "4")
            {
                Console.Write("What is the filename for the goal file?");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                
                currentPoints = int.Parse(File.ReadLines(filename).First());

                foreach (string line in lines)
                {
                    string[] parts = line.Split("#:");

                    if (parts[0] == "SimpleGoal")
                    {
                        entries.Add($"SimpleGoal#:{parts[1]}#:{parts[2]}#:{int.Parse(parts[3])}#:{int.Parse(parts[4])}");
                    }

                    if (parts[0] == "EternalGoal")
                    {
                        entries.Add($"EternalGoal#:{parts[1]}#:{parts[2]}#:{int.Parse(parts[3])}");
                    }

                    if (parts[0] == "ChecklistGoal")
                    {
                        entries.Add($"ChecklistGoal#:{parts[1]}#:{parts[2]}#:{int.Parse(parts[3])}#:{int.Parse(parts[4])}#:{int.Parse(parts[5])}#:{int.Parse(parts[6])}");
                    }
                }
            }

            else if (selection == "5")
            {

                Console.WriteLine("The goals are:");
                int count = 1;
                foreach(string entry in entries)
                {
                    string[] pieces = entry.Split("#:");
                    if(pieces[0] == "SimpleGoal")
                    {   
                        Console.WriteLine($"{count}. {pieces[1]}");
                        count += 1;
                    }

                    else if(pieces[0] == "EternalGoal")
                    {
                        Console.WriteLine($"{count}. {pieces[1]}");
                        count += 1;
                    }

                    else if(pieces[0] == "ChecklistGoal")
                    {
                        ChecklistGoal cg = new ChecklistGoal();
                        Console.WriteLine($"{count}. {pieces[1]}");
                        count += 1;
                    }
                }
                Console.Write("Which goal did you accomplish? ");
                string choice = Console.ReadLine();
                string userChoice = entries[int.Parse(choice) - 1];
                string[] choicePieces = userChoice.Split("#:");

                if (choicePieces[0] == "SimpleGoal")
                {
                    SimpleGoal sg = new SimpleGoal(choicePieces[1],choicePieces[2],int.Parse(choicePieces[3]));
                    currentPoints += sg.RecordEvent();
                    string newString = "";
                    foreach(string entry in entries)
                    {
                        string[] parts = entry.Split("#:");
                        if (choicePieces[1] == parts[1])
                        {
                            newString = $"SimpleGoal#:{choicePieces[1]}#:{choicePieces[2]}#:{int.Parse(choicePieces[3])}#:1";
                        }
                        else
                        {

                        }
                        
                    }
                    entries[int.Parse(choice) - 1] = newString;
                    Console.WriteLine($"\nCongratulations! You have earned {choicePieces[3]} points!");
                    Console.WriteLine($"You now have {currentPoints} points.");
                }
                else if (choicePieces[0] == "EternalGoal")
                {
                    EternalGoal eg = new EternalGoal(choicePieces[1],choicePieces[2],int.Parse(choicePieces[3]));
                    currentPoints += eg.RecordEvent();
                    Console.WriteLine($"\nCongratulations! You have earned {choicePieces[3]} points!");
                    Console.WriteLine($"You now have {currentPoints} points.");
                }
                else if (choicePieces[0] == "ChecklistGoal")
                {
                    
                    ChecklistGoal cg = new ChecklistGoal(choicePieces[1],choicePieces[2],int.Parse(choicePieces[3]),int.Parse(choicePieces[4]),int.Parse(choicePieces[5]),int.Parse(choicePieces[6]));
                    currentPoints += cg.RecordEvent();
                    string newString = "";
                    foreach(string entry in entries)
                    {
                        string[] parts = entry.Split("#:");
                        if (choicePieces[1] == parts[1])
                        {
                            newString = $"ChecklistGoal#:{choicePieces[1]}#:{choicePieces[2]}#:{int.Parse(choicePieces[3])}#:{int.Parse(choicePieces[4])}#:{int.Parse(choicePieces[5])}#:{int.Parse(choicePieces[6]) + 1}";
                            if (int.Parse(parts[6]) < int.Parse(parts[5]) - 1)
                            {
                                Console.WriteLine($"\nCongratulations! You have earned {choicePieces[3]} points!");
                                Console.WriteLine($"You now have {currentPoints} points.");
                                
                            }
                            else
                            {
                                Console.WriteLine($"\nCongratulations! You have earned {int.Parse(choicePieces[3]) + int.Parse(choicePieces[4])} points!");
                                Console.WriteLine($"You now have {currentPoints} points.");
                            }
                        }
                        else
                        {

                        }
                        
                    }
                    entries[int.Parse(choice) - 1] = newString;
                    
                }
                
                
            }

            else if (selection == "6")
            {
                // delete goal
                Console.WriteLine("The goals are:");
                int count = 1;
                foreach(string entry in entries)
                {
                    string[] pieces = entry.Split("#:");
                    if(pieces[0] == "SimpleGoal")
                    {   
                        Console.WriteLine($"{count}. {pieces[1]}");
                        count += 1;
                    }

                    else if(pieces[0] == "EternalGoal")
                    {
                        Console.WriteLine($"{count}. {pieces[1]}");
                        count += 1;
                    }

                    else if(pieces[0] == "ChecklistGoal")
                    {
                        ChecklistGoal cg = new ChecklistGoal();
                        Console.WriteLine($"{count}. {pieces[1]}");
                        count += 1;
                    }
                }
                Console.Write("Which goal would you like to delete? ");
                int response = int.Parse(Console.ReadLine());
                entries.RemoveAt(response - 1);
                
            }

            else if (selection == "7")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid entry. Please enter a value 1-7");
            }
        }
    }
}