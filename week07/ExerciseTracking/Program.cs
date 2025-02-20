using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 2, 20), 30, 4.8),   // Running 4.8 km in 30 min
            new Cycling(new DateTime(2025, 2, 20), 40, 20.0),  // Cycling at 20 kph for 40 min
            new Swimming(new DateTime(2025, 2, 20), 25, 20)    // Swimming 20 laps in 25 min
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}