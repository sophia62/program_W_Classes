using System;
 public class Resume

{
     public string _name;

     public List<JobsHad> _jobsHad = new List<JobsHad>();

     public void Display()

     {
        Console.WriteLine ($"Name: {_name}");
        Console.WriteLine("Past Jobs:");


        foreach (JobsHad jobs in _jobsHad)
        {

            jobs.Display();
        }
     }



    


    
}