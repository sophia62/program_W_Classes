public class SimpleGoal : CreateGoal 
{
    public SimpleGoal(string goal, string description, int points)
        : base(goal, description, points)
    {}
    public override string GetStringRepresentation()
    {
   
        return $"SimpleGoal| {Goal}|Description:{Description}|Points:{Points}";
    }

    public override void RecordEvent(ref int userScore)
    {
        userScore += Points;
        Console.WriteLine($"Congratulations, you've earned {Points} points!");
    }

    public override void LoadFromStringRepresentation(string line)
    {
        string[] parts = line.Split('|');
        Goal = parts[1];
        Description = parts[2];
         Points = int.Parse(parts[3].Replace("Points:", "").Trim());
    }
        }

