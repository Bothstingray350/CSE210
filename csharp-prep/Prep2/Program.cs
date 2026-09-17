using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? (0-100): ");
        string strGrade = Console.ReadLine();
        float intGrade = float.Parse(strGrade);
        char letterGrade = 'X';
        switch (intGrade) {
            case float number when number >= 90:
                letterGrade = 'A';
                break;
            case float number when number >= 80:
                letterGrade = 'B';
                break;
            case float number when number >= 70:
                letterGrade = 'C';
                break;
            case float number when number >= 60:
                letterGrade = 'D';
                break;
            case float number when number < 60:
                letterGrade = 'F';
                break;
        }

        Console.WriteLine($"Your letter grade is {letterGrade}");

        if (intGrade >= 70)
        {
            Console.WriteLine("You've passed, good job!");
        }
        else
        {
            Console.WriteLine("You've failed, better luck next time");
        }


    }
}