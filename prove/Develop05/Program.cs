using System;
using System.Collections.Generic;

List<CreateGoal> goals = new List<CreateGoal>();
int userScore = 0;

while (true)
{
    Console.WriteLine("1. Create new Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Save Goals");
    Console.WriteLine("4. Load Goals");
    Console.WriteLine("5. Record events");
    Console.WriteLine("6. Display Score");
    Console.WriteLine("7. Exit");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CreateGoal.CreateNewGoal(goals);
            break;
        case "2":
            DisplayGoal.Display(goals, userScore);
            break;
        case "3":
            Console.WriteLine("Enter the filename to save to:");
            string saveFilename = Console.ReadLine();
            SaveGoal.Save(saveFilename, goals, userScore);
            break;
        case "4":
            Console.WriteLine("Enter the filename to load from:");
            string loadFilename = Console.ReadLine();
            (goals, userScore) = LoadGoal.Load(loadFilename);
            Console.WriteLine("Goals loaded successfully.");
            break;
        case "5":
            RecordEvent.Record(goals, ref userScore);
            break;
        case "6":
            DisplayScore();
            break;
        case "7":
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

void DisplayScore()
{
    Console.WriteLine($"User Score: {userScore}");
}


