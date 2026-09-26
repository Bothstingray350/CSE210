using System;

class Program
{
    static void Main(string[] args)
    {
        Random randInt = new Random();
        int randomNum = randInt.Next(1,11);
        while (true)
        {
            Console.Write("Guess a number from 1-10: ");
            string userGuessStr = Console.ReadLine();
            int userGuessInt = int.Parse(userGuessStr);
            if (userGuessInt > randomNum)
            {
                Console.WriteLine("Lower!");
            } else if (userGuessInt < randomNum)
            {
                Console.WriteLine("Higher!");
            } else if (userGuessInt == randomNum)
            {
                Console.WriteLine("Correct!");
                break;
            }
        }
    }
}