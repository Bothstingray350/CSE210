using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;

    public ReflectionActivity()
    {
        List<string> prompts = new List<string>(); 
        // Add prompts
        _prompts = prompts;
    }

    public ReflectionActivity(List<string> prompts)
    {
        _prompts = prompts;
    }

    public void BeginActivity()
    {
        
    }
}