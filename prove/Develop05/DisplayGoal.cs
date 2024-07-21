public static class DisplayGoal
{
    public static void Display(List<CreateGoal> goals, int userScore)
    {
        Console.WriteLine($"User Score: {userScore}");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
}


