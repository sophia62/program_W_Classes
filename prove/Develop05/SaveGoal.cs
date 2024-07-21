using System.Collections.Generic;
using System.IO;

public static class SaveGoal
{
    public static void Save(string filename, List<CreateGoal> goals, int userScore)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(userScore); // Save the user score first
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
}

