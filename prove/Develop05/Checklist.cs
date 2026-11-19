using System.IO;

class Checklist
{
    private List<Goal> _goals;
    private int _points;

    public Checklist()
    {
        _goals = new List<Goal>();
        _points = 0;
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
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            
        }   
    }
}