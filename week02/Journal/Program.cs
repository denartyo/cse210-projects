using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to your Journal path!");
        Console.WriteLine("1 write a new entry"); 
        Console.WriteLine("2 Display the Journal");
        Console.WriteLine("3 Save the Journal to file");
        Console.WriteLine("4 Load the Journal from file");
        Console.WriteLine("5 Quit");
        Console.Write("What do you want to do?");
        string userinput = Console.ReadLine();
        int number = int.Parse(userinput);
        List <string> prompts = new List<string>();
        prompts.Add("What was the most beautiful thing you did today?");
        prompts.Add("What was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        if (number == 1)
        {
            List(prompts);
        }

    }
}
