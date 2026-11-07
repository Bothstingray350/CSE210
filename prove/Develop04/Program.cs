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
        do
        {
            Console.WriteLine("Select an activity to start:\n\n0.Quit\n1.Breathing Activity\n2.Reflection Activity\n3.Listening Activity");
            userIn = Console.ReadLine();
            switch (userIn)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":

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