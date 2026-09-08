using System;

// Create a class (custom data types) to use in Program
public class Job
{
    // Create Member variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Create custom method to format and display data stored in 'Job'
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}