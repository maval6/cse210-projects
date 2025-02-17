using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"Activity: {_name} | Duration: {_duration} seconds");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = {"|", "/", "-", "\\"};
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b ");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b ");
        }
    }

    public abstract void Run();
}

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by guiding you through deep breathing.") {}

    public override void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectingActivity() : base("Reflection", "This activity helps you reflect on moments of strength and resilience.") {}

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
    private string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you list things that bring you joy and positivity.") {}

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);
        Console.WriteLine("Start listing items...");
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) items.Add(input);
        }
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => throw new InvalidOperationException("Invalid option.")
            };
            
            if (activity == null) break;
            activity.Run();
        }
    }
}
