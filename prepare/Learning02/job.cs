using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public Job()
    {
        job._jobTitle = "Software Engineer";
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle}");
    }
}
