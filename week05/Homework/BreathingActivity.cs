using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity helps you relax by guiding you to breathe in and out slowly. Focus on your breathing.")
    {}

    public void Run()
    {
        Start();
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            elapsed += 4;

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
            elapsed += 4;
        }
        End();
    }
}
