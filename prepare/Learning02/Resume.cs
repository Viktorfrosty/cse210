using System;

public class Resume
{
    public string _personName;
    public List<Job> _jobsList = new List<Job>();

    public void ResumeDisplay()
    {
        Console.WriteLine($"Name: {_personName}\nJobs:");
        foreach (Job Job in _jobsList)
        {
            Job.JobDisplay();
        }
    }
}
