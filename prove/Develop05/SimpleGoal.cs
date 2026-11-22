using System.ComponentModel;

class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points, bool completed) : base(title, description, points)
    {
        _completed = completed;
    }

    public override string GetSaveString()
    {
        return $"Simple|{_title}|{_description}|{_points}|{_completed}";
    }

    public override void Display()
    {
        string isComplete;
        if(_completed)
        {
            isComplete = "X";
        } else
        {
            isComplete = " ";
        }
        Console.WriteLine($"[{isComplete}] {_title}: {_description}");
    }

    public override int Progress()
    {
        _completed = true;
        return _points;
    }
}