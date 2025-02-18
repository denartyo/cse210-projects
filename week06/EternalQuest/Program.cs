using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;
    private const string FileName = "goals.txt"; // File to store data

    static void Main()
    {
        LoadGoals(); // Load saved goals at startup

        while (true)
        {
            Console.WriteLine("\nEternal Quest - Goal Tracker");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save and Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    Console.WriteLine($"Current Score: {_score} points");
                    break;
                case "5":
                    SaveGoals();
                    Console.WriteLine("Progress saved. Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
            {
                case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
                case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
                case "3":
                Console.Write("Enter target completion count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing target: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
                default:
                Console.WriteLine("Invalid choice.");
                return;
            }

    _goals.Add(newGoal);
    Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter the number of the goal to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int pointsEarned = _goals[index].RecordEvent(); // Get points from goal
            _score += pointsEarned; // Update score
            Console.WriteLine($"Progress recorded! You earned {pointsEarned} points. Your new score: {_score}");
        }
        else
            {
                Console.WriteLine("Invalid goal number.");
            }
    }



    static void ShowGoals()
    {
    Console.WriteLine("\nYour Goals:");
    for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }



    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(FileName))
    {
        writer.WriteLine(_score); // Save score first

        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal sg)
            {
                writer.WriteLine($"Simple|{sg.GetName()}|{sg.GetDescription()}|{sg.GetPoints()}|{sg.IsCompleted()}");
            }
            else if (goal is EternalGoal eg)
            {
                writer.WriteLine($"Eternal|{eg.GetName()}|{eg.GetDescription()}|{eg.GetPoints()}");
            }
            else if (goal is ChecklistGoal cg)
            {
                writer.WriteLine($"Checklist|{cg.GetName()}|{cg.GetDescription()}|{cg.GetPoints()}|{cg.GetTargetCount()}|{cg.GetCurrentCount()}|{cg.GetBonusPoints()}");
            }
        }
    }
    }



    
    static void LoadGoals()
    {
        if (File.Exists(FileName))
        {
            _goals.Clear();

            using (StreamReader reader = new StreamReader(FileName))
            {
                _score = int.Parse(reader.ReadLine()); // Load score

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "Simple")
                    {
                        bool isCompleted = bool.Parse(parts[4]);
                        SimpleGoal sg = new SimpleGoal(name, description, points);
                        if (isCompleted) sg.RecordEvent(); // Mark as completed if needed
                        _goals.Add(sg);
                    }
                    else if (type == "Eternal")
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == "Checklist")
                    {
                        int targetCount = int.Parse(parts[4]);
                        int currentCount = int.Parse(parts[5]);
                        int bonusPoints = int.Parse(parts[6]);
                        ChecklistGoal cg = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                        for (int i = 0; i < currentCount; i++) cg.RecordEvent(); // Restore progress
                        _goals.Add(cg);
                    }
                }
            }
        }
    }
}