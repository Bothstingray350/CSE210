using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string userIn;
        BreathingActivity a1 = new BreathingActivity();
        ReflectionActivity a2 = new ReflectionActivity();
        ListingActivity a3 = new ListingActivity();
        do
        {
            Console.Write("Select an activity to start:\n\n0.Quit\n1.Breathing Activity\n2.Reflection Activity\n3.Listing Activity\n4.Secret\n\nYour Choice: ");
            userIn = Console.ReadLine();
            switch (userIn)
            {
                case "1":
                    a1.DisplayIntro();
                    a1.BeginActivity(a1.GetDuration());
                    a1.DisplayOutro();
                    break;
                case "2":
                    a2.DisplayIntro();
                    a2.BeginActivity(a2.GetDuration());
                    a2.DisplayOutro();
                    break;
                case "3":
                    a3.DisplayIntro();
                    a3.BeginActivity(a3.GetDuration());
                    a3.DisplayOutro();
                    break;
                case "4":
                    Animations.LilFellaWaving();
                    break;
                case "0":
                    Console.Write("Goodbye!");
                    quit=true;
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    break;
            }
        } while (!quit);
    }
}