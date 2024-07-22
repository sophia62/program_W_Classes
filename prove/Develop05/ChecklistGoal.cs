public class ChecklistGoal : CreateGoal
{
    public int TimesNeeded { get; set; }
    public int TimesCompleted { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string goal, string description, int points, int timesNeeded, int bonusPoints)
        : base(goal, description, points)
    {
        TimesNeeded = timesNeeded;
        BonusPoints = bonusPoints;
    }

    public override string GetStringRepresentation()
    {
        string completedMark = TimesCompleted >= TimesNeeded ? "[x]" : "";
        return $"ChecklistGoal|{Goal}|Description: {Description}|{Points}|Times needed for completion:{TimesNeeded}|Times goal has been done:{TimesCompleted}|Bonus Points: {BonusPoints}|Has completed:{completedMark}";
    }

    public override void RecordEvent(ref int userScore)
    {
        TimesCompleted++;
        userScore += Points;
        Console.WriteLine($"Congratulations, you've earned {Points} points!");

        if (TimesCompleted >= TimesNeeded)
        {
            userScore += BonusPoints;
            Console.WriteLine($"Bonus! You've completed the checklist goal and earned an additional {BonusPoints} points!");
        }
    }

    public override void LoadFromStringRepresentation(string line)
    {
        string[] parts = line.Split('|');
        Goal = parts[1];
        Description = parts[2];
        Points = int.Parse(parts[3]);
        TimesNeeded = int.Parse(parts[4]);

        string timesCompletedPart = parts[5];
        if (timesCompletedPart.EndsWith("[x]"))
        {
            TimesCompleted = int.Parse(timesCompletedPart.Substring(0, timesCompletedPart.Length - 3));
        }
        else
        {
            TimesCompleted = int.Parse(timesCompletedPart);
        }

        BonusPoints = int.Parse(parts[6]);
    }
}

