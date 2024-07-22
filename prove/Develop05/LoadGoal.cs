using System;
using System.Collections.Generic;
using System.IO;

public static class LoadGoal
{
    private const int V = 2;

    public static (List<CreateGoal>, int) Load(string filename)
    {
        List<CreateGoal> goals = new List<CreateGoal>();
        int userScore = 0;

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                userScore = int.Parse(lines[0]); // Load the user score from the first line
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split('|');
                string type = parts[0];

                CreateGoal goal = null;

                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3].Replace("Points:", "").Trim()));
                        
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3].Replace("Points:", "").Trim()));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3].Replace("Points:", "").Trim()), 
                                                int.Parse(parts[4].Replace("Times needed for completion:", "").Trim()), 
                                                int.Parse(parts[6].Replace("Bonus Points:", "").Trim()))
                        {
                            TimesCompleted = int.Parse(parts[5].Replace("Times goal has been done:", "").Trim().TrimEnd("[x]".ToCharArray()))
                        };
                        break;
                }

                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }

        return (goals, userScore);
    }
}




