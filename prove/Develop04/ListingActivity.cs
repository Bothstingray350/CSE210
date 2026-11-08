using System.Diagnostics;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
    {
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
        _title = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public ListingActivity(List<string> prompts)
    {
        _prompts = prompts;
        _title = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void BeginActivity(int duration)
    {
        Random rand = new Random();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        DateTime current = start;
        List<string> responses = new List<string>();
        Console.Clear();
        Console.Write("Get Ready... ");
        Animations.ShowSpinner();
        Console.WriteLine();
        Console.Write(_prompts[rand.Next(0, _prompts.Count)]);
        Animations.ShowSpinner(4);
        Console.WriteLine();
        Console.Write("Get ready to list responses...");
        Animations.CountDown(5);
        Console.WriteLine();
        Console.WriteLine("List your responses:\n");
        while (current < end)
        {
            responses.Add(Console.ReadLine());
            current = DateTime.Now;
        }
        Console.Write($"Well Done! You listed {responses.Count} responses!");
        Animations.ShowSpinner();
    }
}