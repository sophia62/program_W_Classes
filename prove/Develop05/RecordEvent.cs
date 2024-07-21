public static class RecordEvent
{
    public static void Record(List<CreateGoal> goals, ref int userScore)
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events.");
            return;
        }

        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Goal}");
        }

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= goals.Count)
        {
            goals[choice - 1].RecordEvent(ref userScore);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}




