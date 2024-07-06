
using System;
using System.Threading;
using System.Collections.Generic;

// Base Class: MindfulnessActivity
// Attributes:
// protected string name
// protected string description
// protected int duration
// Methods:
// public void StartActivity()
// protected abstract void PerformActivity()
// protected void ShowStartingMessage()
// protected void ShowEndingMessage()
// protected void PauseWithAnimation(int seconds)

abstract public class Mindfullness
{
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    public int Durration { get; set; }

    // Constructor
    public Mindfullness(string name, string description, int durration)
    {
        Name = name;
        Description = description;
        Durration = durration;
    }

    // Method to start the activity
    public void StartActivity()
    {
        PauseWithAnimation(3);
        ShowStartingMessage();
        PauseWithAnimation(3);
        DoActivity();
        ShowEndingMessage();
    }

    // Abstract method to perform the activity
    abstract public void DoActivity();

    // Method to show the starting message
    protected void ShowStartingMessage()
    {
        Console.WriteLine($"Starting {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter duration in seconds: ");
        Durration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
    }

    // Method to show the ending message
    protected void ShowEndingMessage()
    {
        Console.WriteLine("Good job!");
        PauseWithAnimation(3);
        Console.WriteLine($"You have completed the {Name} for {Durration} seconds. Taking you back to the Menu now.");
        PauseWithAnimation(3);
    }

    // Method to pause with an animation
    protected void PauseWithAnimation(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds; i++)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    // Method for a breathing animation
    protected void BreathingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
//Do I want a count down Method????
    // // Static variable to store duration
    // private static int duration = 0;

    // // Method to get the duration
    // public static void GetDuration()
    // {
    //     int seconds;

    //     Console.WriteLine("Enter the number of seconds to run the program: ");
    //     string input = Console.ReadLine();

    //     if (int.TryParse(input, out seconds) && seconds > 0)
    //     {
    //         duration = seconds;
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid input. Please enter a positive integer.");
    //     }
    // }

    // Method to return the duration value
    // public static int GetDurationValue()
    // {
    //     return duration;
    // }

    // // Method to run the activity
    // public void Run()
    // {
    //     int duration = Mindfullness.GetDurationValue();
    //     DateTime startTime = DateTime.UtcNow;

    //     // Loop and run code for duration seconds
    //     while (DateTime.UtcNow.Subtract(startTime) < TimeSpan.FromSeconds(duration)) ;
    // }

    // Override ToString method
    // public override string ToString()
    // {
    //     return $"The Name of the Activity is {Name}, in this activity, {Description}. How much time do you have to spend? {Durration} seconds.";
    // }
}



// // . Base Class: MindfulnessActivity
// // Attributes:
// // protected string name
// // protected string description
// // protected int duration
// // Methods:
// // public void StartActivity()
// // protected abstract void PerformActivity()
// // protected void ShowStartingMessage()
// // protected void ShowEndingMessage()
// // protected void PauseWithAnimation(int seconds)

// using System;
// using System.Threading;
// using System.Diagnostics.Contracts;
// using System.Runtime.Intrinsics.Arm;
// using System.Security.Cryptography.X509Certificates;
// //class mindfullness declared.
// //access level mod (abstract), access mod(private), 



// abstract public class Mindfullness
// {
//     //properties
//     public string Name{get;set;}
//     public string Description{get;set;}
//     public int Durration{get;set;}
//     //constructor
//     public Mindfullness(string name, string description, int durration)
// {
//     Name = name;
//     Description = description;
//     // private static int durration = 0; 
//     Durration = durration;
// }
// //method
// // public void SetDuration()
// //     {
// //         Console.Write("Enter the duration in seconds: ");
// //         string input = Console.ReadLine();
// //         if (int.TryParse(input, out int durration))
// //         {
// //         DateTime startTime = DateTime.Now;
// //         DateTime endTime = startTime.AddSeconds(Durration);
// //             Durration = durration;
// //         }
//     public override string ToString()
//     {
//         return 
//             $"The Name of the Game is {Name}, in this activity,{Description}. How much time do you have to spend? {Durration}";
//     }
//     public void StartActivity()
//     {
//         ShowStartingMessage();
//         PauseWithAnimation();
//         DoActivity();
//         ShowEndingMessage();
//     }

//     abstract public void DoActivity();
//     public void ShowStartingMessage()
//     {
//         Console.WriteLine($"Starting {Name}");
//         Console.WriteLine(Description);
//         Console.Write("Enter duration in seconds: ");
//         duration = int.Parse(Console.ReadLine());
//         Console.WriteLine("Prepare to begin...");   
//     }
//     protected void ShowEndingMessage()
//     {
//         Console.WriteLine("Good job!");
//         Console.WriteLine($"You have completed the {Name} for {Durration} seconds.");
//     }
//     protected void PauseWithAnimation()
//     {
//         List<string> animationStrings = new List<string>();
//         animationStrings.Add("|");
//         animationStrings.Add("/");
//         animationStrings.Add("-");
//         animationStrings.Add("\\");
//         animationStrings.Add("|");
//         animationStrings.Add("/");
// foreach (string s in animationStrings)
// {
//     Console.Write(s);
//     Thread.Sleep(1000);
//      Console.Write("\b \b");
// }
// }
// protected void BreathingAnimation(int seconds)
// {
//             for (int i = 0; i < seconds; i++)
//         {
//             Console.Write(".");
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine();
// }
// // public static class TimeManager

//     private static int duration = 0; // Static variable to store duration

//     public static void GetDuration()
//     {
//         int seconds;

//         Console.WriteLine("Enter the number of seconds to run the program: ");
//         string input = Console.ReadLine();

//         if (int.TryParse(input, out seconds) && seconds > 0)
//         {
//             duration = seconds;
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a positive integer.");
//         }
//     }

//     public static int GetDurationValue()
//     {
//         return duration;
//     }
//     public void Run()
//     {
//         int duration = Mindfullness.GetDurationValue();
//         DateTime startTime = DateTime.UtcNow;

//         // Loop and run code for Class1 for duration seconds
//         while (DateTime.UtcNow.Subtract(startTime) < TimeSpan.FromSeconds(duration));
// }}




//DateTime startTime = DateTime.Now;
//DateTime endTime = startTime.AddSeconds(Durration)
// protected void PauseWithAnimation()
//     {
//         List<string> animationStrings =
//         [
//             "|",
//             "/",
//             "-",
//             "\\",
//             "|",
//             "/",
//         ];
        // for (int i = 0; i < seconds; i++)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        // }
        // Console.WriteLine();
    
// }

// List<string> animationStrings = new List<string>();
// animationStrings.Add("|");
// animationStrings.Add("/");
// animationStrings.Add("-");
// animationStrings.Add("\\");
// animationStrings.Add("|");
// animationStrings.Add("/");
// foreach (string s in animationStrings)
// {
//     Console.Write(s);
//     Thread.Sleep(1000);
//      Console.Write("\b \b");
// }






//     {

//         public void ShowStartMessage()
//     {  
//         Console.WriteLine("This is the Start Message");
//     }
//     public void ShowEndtMessage()
//     {
        
//         Console.WriteLine("This is the End Message");
//     }
//     public void PauseWithAnimation()
//     {

//     }
    
//     public DoActivity()
// {
//     Console.WriteLine("What is yout name");
//     Console.ReadLine (name})
// }
// }
