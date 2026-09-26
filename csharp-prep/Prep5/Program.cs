using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        string usernum = Console.ReadLine();
        int userint = int.Parse(usernum);
        return userint;
    }

    static void AskForBirthdate(out int birthdate)
    {
        Console.Write("What is your date of birth?: ");
        string birthdateStr = Console.ReadLine();
        birthdate = int.Parse(birthdateStr);
    }

    static int SquareNum(int number)
    {
        return number * number;
    }

    static void DisplayResults(string username, int squaredNum, int birthdate)
    {
        int age = 2026 - birthdate;
        Console.WriteLine($"{username}, the square of your number is {squaredNum}");
        Console.WriteLine($"{username}, you will turn {age} this year");
    }

    static void Main(string[] args)
    {
        int birthdate;
        DisplayWelcome();
        string username = PromptUserName();
        int userNum = PromptUserNumber();
        AskForBirthdate(out birthdate);
        int squaredNum = SquareNum(userNum);
        DisplayResults(username, squaredNum, birthdate);
    }
}