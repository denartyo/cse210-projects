using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing",
        "This activity will help you reflect on the good things in your life.")
    { }

    public override void RunActivity()
    {
        StartActivity();
        Random random = new Random();
        
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(5);

        Console.WriteLine("Start listing items. Press Enter after each one.");
        int count = 0;
        int startTime = Environment.TickCount;
        
        while ((Environment.TickCount - startTime) / 1000 < _duration)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}
