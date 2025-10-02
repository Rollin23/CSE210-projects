using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._title = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._title = "Web Developer";
        job2._company = "Google";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Johnie Lingo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }

}