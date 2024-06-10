using System;

public class JobsHad
{
    public string _Role;
    public string _Company;
    public int _startYear;

// making _endYear a string because I am putting "present" as one of the job end years
    public string _endYear;


     public void Display()


{
    Console.WriteLine($"{_Role}, {_Company}, {_startYear} through {_endYear}");
}
}