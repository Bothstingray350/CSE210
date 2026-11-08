public static class Animations
{
    public static void ShowSpinner(int? duration = null)
    {
        int actualDuration = duration ?? 2;
        DateTime start = DateTime.Now;
        DateTime future = start.AddSeconds(actualDuration);
        DateTime current = start;
        int animationSleep = 100;

        while (current <= future)
        {
            Console.Write("/");
            Thread.Sleep(animationSleep);
            Console.Write("\b|");
            Thread.Sleep(animationSleep);
            Console.Write("\b\\");
            Thread.Sleep(animationSleep);
            Console.Write("\b-");
            Thread.Sleep(animationSleep);
            Console.Write("\b");
            current = DateTime.Now;
        }
        Console.Write(" ");
    }
    public static void CountDown(int countFrom)
    {
        while (countFrom > 0)
        {
            Console.Write(countFrom);
            Thread.Sleep(1000);
            Console.Write("\b");
            countFrom --;
        }
        Console.Write(" ");
    }
    public static void LilFellaWaving()
    {
        Console.Clear();
        Thread.Sleep(1000);

        int startX = Console.CursorLeft;
        int startY = Console.CursorTop;

        for (int i = 0; i < 10; i++)
        {
            Console.SetCursorPosition(startX, startY);
            Console.Write(" O/ ");
            Console.WriteLine("\n/|  ");
            Console.WriteLine(" Λ ");

            Thread.Sleep(300);

            Console.SetCursorPosition(startX, startY);
            Console.Write(" O  "); 
            Console.WriteLine("\n/|\\ ");
            Console.WriteLine(" Λ ");

            Thread.Sleep(300);
        }

        Console.SetCursorPosition(startX, startY);
        Console.WriteLine(" O7");
        Console.WriteLine("/| ");
        Console.WriteLine(" Λ");

        ShowSpinner(5);
        Console.Clear();
    }
}