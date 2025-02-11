using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", 
        "This activity will help you relax by guiding you through slow breathing.")
    { }

    public override void RunActivity()
    {
        StartActivity();
        
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 6;
        }

        EndActivity();
    }
}
