public class ListeningActivity : Activity
{
    private List<string> _introPrompts;
    private List<string> _secondaryPrompts;

    public ListeningActivity(string title, string description, int duration) :base(title, description, duration)
    {
        List<string> introPrompts = new List<string>();
        List<string> secondaryPrompts = new List<string>();
        _introPrompts = introPrompts;
        _secondaryPrompts = secondaryPrompts;
    }

    public ListeningActivity(List<string> introPrompts, List<string> secondaryPrompts, string title, 
                        string description, int duration) :base(title, description, duration)
    {
        _introPrompts = introPrompts;
        _secondaryPrompts = secondaryPrompts;
    }

    public void BeginActivity()
    {
        
    }
}