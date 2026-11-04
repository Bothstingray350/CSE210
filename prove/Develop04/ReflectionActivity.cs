using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;

    public ReflectionActivity(string title, string description, int duration) :base(title, description, duration)
    {
        List<string> prompts = new List<string>(); 
        _prompts = prompts;
    }

    public ReflectionActivity(List<string> prompts, string title, string description, int duration) :base(title, description, duration)
    {
        _prompts = prompts;
    }

    public void BeginActivity()
    {
        
    }
}