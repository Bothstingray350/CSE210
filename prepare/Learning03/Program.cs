using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Fraction f = new Fraction();

        for (int i = 0; i < 20; i++)
        {
            f.SetTop(r.Next(20));
            f.SetBottom(r.Next(1, 20));
            Console.WriteLine($"Fraction {i+1}: string:{f.GetFractionString()} number:{f.GetDecimalValue()}");
        }
    }
}