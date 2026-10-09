
using System.IO;
public class Journal
{
    public List<Entry> _entires = new List<Entry>();
    public List<string> _prompts = new List<string>();
    Random random = new Random();

    public void AddEntry()
    {
        Entry entry = new Entry();
        string newPrompt = _prompts[random.Next(_prompts.Count)];
        Console.Write($"{newPrompt}: ");
        string newResponse = Console.ReadLine();

        entry._prompt = newPrompt;
        entry._response = newResponse;
        entry._date = DateTime.Today.ToShortDateString();

        _entires.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entires)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entires)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }
    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = new  Entry();
            string[] parts = line.Split("|");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entires.Add(entry);
        }
    }
    public void AddPrompt()
    {
        Console.Write("What propmt would you like to add?: ");
        _prompts.Add(Console.ReadLine());
        Console.WriteLine("Prompt added!");
    }
}