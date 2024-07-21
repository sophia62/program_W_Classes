public class ClothingItem : BaseItem
{
    public ClothingItem(string name, double weight) : base(name, weight) { }


     public override void DisplayDetails()
     {
        Console.WriteLine($"Clothing Item: {Name}, Weight: {Weight}");
    }

public static void DisplayItems(Cart cart)
{


        Console.WriteLine("Choose an item to add:");
        Console.WriteLine("1. Shirt - 0.5 lbs");
        Console.WriteLine("2. Pants - 1.0 lbs");
        Console.WriteLine("3. Jacket - 5.0 lbs");
string itemChoice = Console.ReadLine();
        BaseItem item = null;

        switch (itemChoice)
        {
            case "1":
                item = new ClothingItem("Shirt", 0.5);
                break;
            case "2":
                item = new ClothingItem ("Pants", 1);
                break;
            case "3":
                item = new ClothingItem ("Jacket", 5);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        cart.AddItem(item);
    }
}


