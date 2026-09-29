using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "SWE";
        job1._startYear = 2012;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Hardware design";
        job2._startYear = 1;
        job2._endYear = 3742;

        Resume resume1 = new Resume();
        resume1._name = "Bob";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}