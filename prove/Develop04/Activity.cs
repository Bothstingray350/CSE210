public class Activity
{
    private string _title;
    private string _description;
    private int _duration;

    public Activity(string title, string description, int duration)
    {
        _title = title;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayIntro()
    {
        Console.WriteLine($"Welcome to the {_title}.\n\n{_description}\n");
        while (true)
        {
            try
            {    
                Console.WriteLine("How long (in seconds) would you like the activity to be?");
                _duration = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception) // Bad but I dont want to write 3 catches
            {
                Console.WriteLine("Invalid input, please try again");
            }
        }
    }

    public void DisplayOutro()
    {
        Console.WriteLine($"You have successfully completed {_duration} seconds of the {_title}!");
    }
}