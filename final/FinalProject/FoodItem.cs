public class FoodItem : BaseItem
{
    public FoodItem(string name, double weight) : base(name, weight) { }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Food Item: {Name}, Weight: {Weight}");
    }

    public static void DisplayItems(Cart cart)
    {
        Console.WriteLine("Choose an item to add:");
        Console.WriteLine("1. Apple - 2 lbs");
        Console.WriteLine("2. Banana - 1 lbs");
        Console.WriteLine("3. Cheetos - 3 lbs");

        string itemChoice = Console.ReadLine();
        BaseItem item = null;

        switch (itemChoice)
        {
            case "1":
                item = new FoodItem("Apple", 2);
                break;
            case "2":
                item = new FoodItem("Banana", 1);
                break;
            case "3":
                item = new FoodItem("Cheetos", 3);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        cart.AddItem(item);
    }
}




