using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job job2 = new job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        resume resume = new resume();
        resume._personName = "Dalan";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();

    }
}