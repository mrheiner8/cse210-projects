using System;

// Create a class (custom data types) to use in Program
public class Resume
{
    // Create Member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Create custom method to format and display data stored in 'Resume' and 'Job'
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}:\nJobs:");

        // Iterate through and display formatted '_jobs' list data from 'Job'by calling on 'DisplayJobDetails' from 'Job'
        foreach (Job b in _jobs)
        {
            b.DisplayJobDetails();
        }
    }
}