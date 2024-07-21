public class FurnatureItem : BaseItem
{
    public FurnatureItem(string name, double weight) : base(name, weight) { }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Furnature Item: {Name}, Weight: {Weight}");
    }

    public static void DisplayItems(Cart cart)
    {
        Console.WriteLine("Choose an item to add:");
        Console.WriteLine("1. Chair - 5 lbs");
        Console.WriteLine("2. Lamp - 3 lbs");
        Console.WriteLine("3. Big Chair - 10 lbs");

        string itemChoice = Console.ReadLine();
        BaseItem item = null;

        switch (itemChoice)
        {
            case "1":
                item = new FurnatureItem("Chair", 5);
                break;
            case "2":
                item = new FurnatureItem("Lamp", 3);
                break;
            case "3":
                item = new FurnatureItem("Big Chair", 10);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        cart.AddItem(item);
    }
}

