using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Tech Corp";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;
        

        Job job2 = new Job();
        job2._company = "Web Solutions";
        job2._jobTitle = "Web Developer";
        job2._startYear = 2018;
        job2._endYear = 2020;
        

        Resume Resume1 = new Resume();
        Resume1._name = "Jimmy Firecracker";
        Resume1._jobs.Add(job1);
        Resume1._jobs.Add(job2);
        Resume1.Display();

    }
}