using System;

class Program
{
    static void Main(string[] args)
    {
    JobsHad jobsHad1 = new JobsHad();
    jobsHad1._Role = "Yoga Instructor";
    jobsHad1._Company = "Muv Fitness";
    jobsHad1._startYear = 2020;
    jobsHad1._endYear = "2022";

    JobsHad jobsHad2 = new JobsHad();
    jobsHad2._Role = "Software Engineer Intern";
    jobsHad2._Company = "Google";
    jobsHad2._startYear = 2024;
    jobsHad2._endYear = "2025";
    
    JobsHad jobsHad3 = new JobsHad();
    jobsHad3._Role = "Software Engineer";
    jobsHad3._Company = "Google";
    jobsHad3._startYear = 2025;
    jobsHad3._endYear = "Present";

//adding the resume portion to bring it all together. 
    Resume resume = new Resume();

    resume._name = "Sophia Beebe";

    resume._jobsHad.Add(jobsHad1);
    resume._jobsHad.Add(jobsHad2);
    resume._jobsHad.Add(jobsHad3);

    resume.Display();

    }
}