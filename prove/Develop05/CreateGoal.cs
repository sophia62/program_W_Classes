
public abstract class CreateGoal
{
    public string Goal { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public CreateGoal(string goal, string description, int points)
    {
        Goal = goal;
        Description = description;
        Points = points;
    }

    public static void CreateNewGoal(List<CreateGoal> goals)
    {
        Console.WriteLine("Select goal type: 1. Simple Goal, 2. Eternal Goal, 3. Checklist Goal");
        string typeChoice = Console.ReadLine();

        Console.WriteLine("Enter goal name:");
        string goalName = Console.ReadLine();
        Console.WriteLine("Enter goal description:");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("Enter points:");
        int goalPoints = int.Parse(Console.ReadLine());

        CreateGoal newGoal = null;

        switch (typeChoice)
        {
            case "1":
                newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                break;
            case "2":
                newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                break;
            case "3":
                Console.WriteLine("Enter number of times needed to complete:");
                int timesNeeded = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, timesNeeded, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }

        if (newGoal != null)
        {
            goals.Add(newGoal);
            Console.WriteLine("Goal created successfully.");
        }
    }

    public abstract string GetStringRepresentation();
    public abstract void RecordEvent(ref int userScore);
    public abstract void LoadFromStringRepresentation(string line);
}


