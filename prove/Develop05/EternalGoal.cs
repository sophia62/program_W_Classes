public class EternalGoal : CreateGoal
{
    public EternalGoal(string goal, string description, int points)
        : base(goal, description, points)
    {
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal| {Goal}|Description:{Description}|{Points}";
    }

    public override void RecordEvent(ref int userScore)
    {
        userScore += Points;
        Console.WriteLine($"Congratulations, you've earned {Points} points for your eternal goal!");
    }

    public override void LoadFromStringRepresentation(string line)
    {
        string[] parts = line.Split('|');
        Goal = parts[1];
        Description = parts[2];
        Points = int.Parse(parts[3]);
    }
}

