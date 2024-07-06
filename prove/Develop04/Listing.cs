using System;
using System.Collections.Generic;

public class Listing : Mindfullness
{
    private static List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

  public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
    }

    override public void DoActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Activity will start in 5 seconds");
        PauseWithAnimation(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Durration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item: ");
            Console.ReadLine();
            itemCount++;
            // PauseWithAnimation(5);
        }
        
        Console.WriteLine($"You have listed {itemCount} items.");
    

        string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}}
