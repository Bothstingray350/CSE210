using System.ComponentModel;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    /// <summary>
    /// Display all information associated with Entry instance on a new line for
    /// each section of data
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n");
    } 
}