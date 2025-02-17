using System;
using System.Threading;

public class Activity
{
    protected int duration; // Duration in seconds
    protected string name;
    protected string description;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {name} ---\n");
        Console.WriteLine(description);
        Console.Write("\nEnter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGreat job! You have completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on the {name} activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]}");
            Thread.Sleep(250);
        }
        Console.Write("\r ");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r ");
    }
}
