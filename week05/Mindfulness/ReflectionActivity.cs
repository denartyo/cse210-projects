using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you apply this experience to your future?"
    };

    public ReflectionActivity() : base("Reflection",
        "This activity will help you reflect on times in your life when you showed strength and resilience.")
    { }

    public override void RunActivity()
    {
        StartActivity();
        Random random = new Random();
        
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(5);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(5);
            elapsedTime += 5;
        }

        EndActivity();
    }
}
