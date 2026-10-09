using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Insatiate journal class, initial prompts for journal and quit-out flag
        bool LETMEOUT = false;
        Journal journal1 = new Journal();
        journal1._prompts = [
            "What have you accomplished today that you're proud of?", 
            "What is something you could've done better today?",
            "How did you make something better today?"
        ];
        Console.WriteLine("Welcome to the Journal Program!");
        while (!LETMEOUT)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Add new prompt\n6. Quit");
            Console.Write("What would you like to do?: ");
            // Store user input after parsing for use in switch case
            string userInputStr = Console.ReadLine();
            int userInput;
            try
            {
                userInput = int.Parse(userInputStr);
            }
            catch (FormatException)
            {
                userInput = 0;
            }

            //Extra whitespace
            Console.WriteLine();

            switch (userInput)
            {
                // Write
                case 1:
                    journal1.AddEntry();
                    break;
                // Display
                case 2:
                    journal1.DisplayEntries();
                    break;
                // Load
                case 3:
                    Console.Write("Enter the filename you would like to load: ");
                    string loadFilename = Console.ReadLine();
                    journal1.LoadFile(loadFilename);
                    break;
                // Save
                case 4:
                    Console.Write("What is the filename you would like to save to?: ");
                    string saveFilename = Console.ReadLine();
                    journal1.SaveToFile(saveFilename);
                    break;
                // New Prompt
                case 5:
                    journal1.AddPrompt();
                    break;
                // Quit
                case 6:
                    LETMEOUT = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine($"Invalid input, please try again\n");
                    break;
            }
        }
    }
}