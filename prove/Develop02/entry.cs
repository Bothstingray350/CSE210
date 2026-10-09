using System.ComponentModel;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n");
    } 
}