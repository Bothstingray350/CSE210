using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("student1", "CompE");
        Console.WriteLine(a1.GetSummary());
        MathAssignment m1 = new MathAssignment("student2", "Mathematics", "Section 4", "Problems 1-5");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        WritingAssignment w1 = new WritingAssignment("student3", "English", "Book review");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}