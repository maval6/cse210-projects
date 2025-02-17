using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity helps you reflect on times in your life when you have shown strength and resilience.")
    {}

    public void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Length)]);
        ShowSpinner(3);

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("\n" + questions[rand.Next(questions.Length)]);
            ShowSpinner(5);
            elapsed += 5;
        }
        End();
    }
}
