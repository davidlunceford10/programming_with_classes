using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Epic";
        job1._startYear = 1991;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Azure Developer";
        job2._company = "Microsoft";
        job2._startYear = 2001;
        job2._endYear = 2023;
        
        Resume resume1 = new Resume();
        
        resume1._name = "David Lunchfork";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}