using System.Drawing;

class ChecklistGoal:Goal
{
    private int _timesCompleted;
    private int _timesTillComplete;
    private int _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int timesCompleted, int timesTillComplete, int bonusPoints) : base(title, description, points)
    {
        _timesCompleted = timesCompleted;
        _timesTillComplete = timesTillComplete;
        _bonusPoints = bonusPoints;
    }
    public override string GetSaveString()
    {
        return $"Checklist|{_title}|{_description}|{_points}|{_timesCompleted}|{_timesTillComplete}|{_bonusPoints}";
    }
    public override int Progress()
    {
        if (_timesCompleted == _timesTillComplete)
        {
            return -1;
        }
        _timesCompleted++;
        if (_timesCompleted == _timesTillComplete)
        {
            return _points + _bonusPoints;
        } else
        {
            return _points;
        }
    }
    public override void Display()
    {
        Console.WriteLine($"[{_timesCompleted}/{_timesTillComplete}] {_title}: {_description}");
    }
}