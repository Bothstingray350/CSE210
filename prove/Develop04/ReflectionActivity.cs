using System.Transactions;

public class ReflectionActivity : Activity
{
    private List<string> _introPrompts;
    private List<string> _secondaryPrompts;

    public ReflectionActivity()
    {
        _introPrompts =[
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        _secondaryPrompts = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        _title = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public ReflectionActivity(List<string> introPrompts, List<string> secondaryPrompts)
    {
        _introPrompts = introPrompts;
        _secondaryPrompts = secondaryPrompts;
        _title = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void BeginActivity(int duration)
    {
        Random rand = new Random();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        DateTime current = start;
        Console.Clear();
        Console.Write("Get Ready... ");
        Animations.ShowSpinner();
        Console.WriteLine("\n");
        Console.Write(_introPrompts[rand.Next(0, _introPrompts.Count)]);
        Animations.ShowSpinner(4);
        Console.WriteLine("\n");
        while (current < end)
        {
            Console.Write(_secondaryPrompts[rand.Next(0, _secondaryPrompts.Count)]);
            Animations.ShowSpinner(10);
            Console.WriteLine();
            current = DateTime.Now;
        }
    }
}