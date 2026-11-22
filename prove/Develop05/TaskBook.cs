using System.IO;

class TaskBook
{
    private List<Goal> _goals;
    private int _points;

    public TaskBook()
    {
        _goals = new List<Goal>();
        _points = 0;
    }

    public int GetPoints()
    {
        return _points;
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_points);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _points = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts[0] == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            if (parts[0] == "Eternal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            if (parts[0] == "Checklist")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(goal);
            }
        }   
    }
    public void ListGoals()
    {
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i}: ");
            _goals[i].Display();
        }
    }
    public void LogGoal(int goalNum)
    {
        _points += _goals[goalNum].Progress();
    }
    public void CreateGoal(string goalType, string title, string description, int points)
    {
        switch(goalType)
        {
            case "1":
                SimpleGoal simple = new SimpleGoal(title, description, points, false);
                _goals.Add(simple);
                break;
            case "2":
                EternalGoal eternal = new EternalGoal(title, description, points);
                _goals.Add(eternal);
                break;
            case "3":
                string bonus;
                string timesTillComplete;
                Console.Write("How many times does this goal need to be completed to finish it?: ");
                timesTillComplete = Console.ReadLine();
                Console.Write("How many bonus points should be rewarded for finishing this goal?: ");
                bonus = Console.ReadLine();
                ChecklistGoal checklist = new ChecklistGoal(title, description, points, 0, int.Parse(timesTillComplete), int.Parse(bonus));
                _goals.Add(checklist);
                break;
        }
    }
    public int GetGoalCount()
    {
        return _goals.Count;
    }
}