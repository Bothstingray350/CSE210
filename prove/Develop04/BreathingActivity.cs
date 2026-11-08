public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _title = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void BeginActivity(int duration)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(duration);
        DateTime current = start;
        Console.Clear();
        Console.Write("Get Ready... ");
        Animations.ShowSpinner();
        Console.Write("\n\nBreathe in...");
        Animations.CountDown(4);
        Console.Write("\n\nBreathe out...");
        Animations.CountDown(4);
        while (current < end)
        {
            Console.Write("\n\nBreathe in...");
            Animations.CountDown(6);
            Console.Write("\n\nBreathe out...");
            Animations.CountDown(6);
            current = DateTime.Now;
        }
    }
}