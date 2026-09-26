using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new List<int>();
        int sum = 0;
        int largest = 0;
        while (true)
        {
            Console.Write("Enter a number to be store and 0 when you are done: ");
            string userStr = Console.ReadLine();   
            int userInt = int.Parse(userStr);
            if (userInt == 0)
            {
                break;
            } else
            {
                ints.Add(userInt);
            }
        }
        foreach (int num in ints)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        float average = sum / ints.Count;
        Console.WriteLine($"The largest is {largest}");
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
    }
}