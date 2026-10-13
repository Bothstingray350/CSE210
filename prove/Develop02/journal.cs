
using System.IO;
public class Journal
{
    public List<Entry> _entires = new List<Entry>();
    public List<string> _prompts = new List<string>();
    Random random = new Random();

    /// <summary> 
    /// Ask user random prompt then save prompt, response, and date to _entries.
    /// </summary>
    public void AddEntry()
    {
        // Create new entry instance
        Entry entry = new Entry();
        // Choose random prompt based on length of prompts list and display
        string newPrompt = _prompts[random.Next(_prompts.Count)];
        Console.Write($"{newPrompt}: ");
        string newResponse = Console.ReadLine();

        // Save information to entry instance and add to _entries
        entry._prompt = newPrompt;
        entry._response = newResponse;
        entry._date = DateTime.Today.ToShortDateString();

        _entires.Add(entry);
    }
    /// <summary>
    /// Iterate over all entry instances in _entries and call their display method.
    /// </summary>
    public void DisplayEntries()
    {
        foreach (Entry entry in _entires)
        {
            entry.Display();
        }
    }
    /// <summary>
    /// Save _entries to txt file using seperator "|", in order of date|prompt|response.
    /// </summary
    /// <param name="filename">Name of file, user must enter type of file (.txt).</param>
    public void SaveToFile(string filename)
    {
        // Declare output file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entires)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }
    /// <summary>
    /// Load entries from file into _entries list, expecting the seperator "|" and the format date|prompt|response
    /// </summary
    /// <param name="filename">Name of file, user must enter type of file (.txt).</param>
    public void LoadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Create new entry instance
            Entry entry = new Entry();
            // Split into date, prompt, response
            string[] parts = line.Split("|");
            // Add to entry instance and add to _entries
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entires.Add(entry);
        }
    }
    /// <summary>
    /// Ask user for a new prompt and add to _prompts list
    /// </summary>
    public void AddPrompt()
    {
        Console.Write("What propmt would you like to add?: ");
        _prompts.Add(Console.ReadLine());
        Console.WriteLine("Prompt added!");
    }
}