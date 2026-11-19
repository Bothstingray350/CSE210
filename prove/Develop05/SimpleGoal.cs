class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _completed = false;
    }

    public override string GetSaveString()
    {
        return $"S|{_title}|{_description}|{_points}|{_completed}";
    }
    
    public override void Display()
    {
        Console.WriteLine($"Simple Goal");
    }

    public override int Progress()
    {
        _completed = true;
        return _points;
    }
}