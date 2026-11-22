using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        TaskBook task1 = new TaskBook();
        string userIn = "";
        bool quit = false;
        string filename;
        Console.WriteLine("Welcom to the Goal Tracker!");
        while(!quit)
        {
            Console.WriteLine($"\nYour Points: {task1.GetPoints()}");
            Console.WriteLine("Please Select one of the following\n");
            Console.WriteLine("0: Quit");
            Console.WriteLine("1: List Goals");
            Console.WriteLine("2: Log Goal");
            Console.WriteLine("3: Create New Goal");
            Console.WriteLine("4: Load Goals From File");
            Console.WriteLine("5: Save Goals To File");
            Console.WriteLine("6: Show Goal Count");
            Console.Write("Your Choice: ");
            userIn = Console.ReadLine();
            Console.WriteLine();
            switch(userIn)
            {
                case "0":
                    quit = true;
                    break;
                case "1":
                    Console.WriteLine("Goals: \n");
                    task1.ListGoals();
                    Console.WriteLine("");
                    break;
                case "2":
                    string goalNum;
                    task1.ListGoals();
                    Console.WriteLine("\nSelect a goal to log");
                    Console.Write("Goal number: ");
                    goalNum = Console.ReadLine();
                    task1.LogGoal(int.Parse(goalNum));
                    break;
                case "3":
                    string goalType;
                    string goalTitle;
                    string goalDescription;
                    string goalPoints;
                    Console.WriteLine("Select a goal type: \n\n1. Simple\n2. Eternal\n3. Checklist");
                    Console.Write("Your choice: ");
                    goalType = Console.ReadLine();
                    Console.Write("What is the name of this goal?: ");
                    goalTitle = Console.ReadLine();
                    Console.Write("What is the description of this goal?: ");
                    goalDescription = Console.ReadLine();
                    Console.Write("How many points should be rewarded for progressing in this goal?: ");
                    goalPoints = Console.ReadLine();
                    task1.CreateGoal(goalType, goalTitle, goalDescription, int.Parse(goalPoints));
                    break;
                case "4":
                    Console.Write("Filename: ");
                    filename = Console.ReadLine();
                    task1.LoadFromFile(filename);
                    break;
                case "5":
                    Console.Write("Filename: ");
                    filename = Console.ReadLine();
                    task1.SaveToFile(filename);
                    break;
                case "6":
                    Console.WriteLine($"Number of goals: {task1.GetGoalCount()}");
                    break;
            }
        }
    }
}