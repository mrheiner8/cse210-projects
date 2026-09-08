using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Name and create a 'Resume' instance
        Resume name1 = new Resume();
        name1._name = "Allison Rose";

        // Name and create a 'Job' instance   
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Name and create another 'Job' instance
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Add raw data from 'job1' and 'job2' to 'name1._jobs' 
        name1._jobs.Add(job1);
        name1._jobs.Add(job2);

        // Display formatted 'Job' and 'Resume' data by calling on the method from 'Resume'.
        name1.DisplayResumeDetails();
    }
}