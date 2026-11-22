class EternalGoal:Goal
{
    public EternalGoal(string title, string description, int points) : base(title,description, points){}

    public override string GetSaveString()
    {
        return $"Eternal|{_title}|{_description}|{_points}";
    }
    public override int Progress()
    {
        return _points;
    }
    public override void Display()
    {
        Console.WriteLine($"[N/A] {_title}: {_description}");
    }
}