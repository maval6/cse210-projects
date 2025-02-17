using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are things you are grateful for?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity helps you reflect on the good things in your life by listing as many things as you can.")
    {}

    public void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine("\n" + prompts[rand.Next(prompts.Length)]);
        ShowCountdown(5);

        List<string> responses = new List<string>();
        int elapsed = 0;
        Console.WriteLine("\nStart listing items:");

        while (elapsed < duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            elapsed += 2; // Assume 2 seconds per response
        }

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        End();
    }
}
