using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Sofware engineer";
        Job1._startYear = 2022;
        Job1._endYear = 2023;
        //Console.WriteLine(Job1._company);
        //Job1.JobDisplay();

        Job Job2 = new Job();
        Job2._company = "Apple";
        Job2._jobTitle = "Manager";
        Job2._startYear = 2021;
        Job2._endYear = 2022;
        //Console.WriteLine(Job2._company);
        //Job2.JobDisplay();

        Resume personalResume = new Resume();
        personalResume._jobsList.Add(Job1);
        personalResume._jobsList.Add(Job2);
        personalResume._personName = "Victor Malpica";
        personalResume.ResumeDisplay();
    }
}
