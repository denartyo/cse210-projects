using System;

public class Program
{
    private Journal _journal;
    private Prompt _promptGenerator;

    public Program()
    {
        _journal = new Journal();
        _promptGenerator = new Prompt();
    }

    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    _journal.DisplayAll();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private void WriteNewEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        var entry = new Entry(prompt, response);
        _journal.AddEntry(entry);
    }

    private void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        _journal.SaveToFile(filename);
    }

    private void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        _journal.LoadFromFile(filename);
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.MainMenu();
    }
}
