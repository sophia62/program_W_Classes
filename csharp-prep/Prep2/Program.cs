using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your percentage score?");
        string percentageString = Console.ReadLine();
        int percentage = int.Parse(percentageString);
    //  if percentage = <93
    if (percentage >=93)
    {
        Console.WriteLine("A");
    }
    //  if percentage is = 80-92
     if (percentage <93 && percentage >=80)
    {
        Console.WriteLine("B");
    }
    //  if percentage is 79-60
     if (percentage <79 && percentage >=70)
    {
        Console.WriteLine("C");
    }
      if (percentage <69 && percentage >=61)
    {
        Console.WriteLine("D");
    }
    //  else if percentage is 60
    if (percentage <=60)
    {
        Console.WriteLine("F");
    }



        
    }
}