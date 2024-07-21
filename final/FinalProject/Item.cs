// public class Item : BaseItem
// {
//     public Item(string name, double weight) : base(name, weight) { }

// static public void AddItemToCart(Cart cart)
//     {
//         Console.WriteLine("\nChoose a category:");
//         Console.WriteLine("1. Food");
//         Console.WriteLine("2. Clothing");
//         Console.WriteLine("3. Furniture");

//         string categoryChoice = Console.ReadLine();

//         switch (categoryChoice)
//         {
//             case "1":
//                 Console.WriteLine("Choose an item to add:");
//                 Console.WriteLine("1. Apple - 2 lbs");
//                 Console.WriteLine("2. Banana - 1 lbs");
//                 Console.WriteLine("3. Cheetos - 3 lbs");
//                 break;
//             case "2":
//                 Console.WriteLine("Choose an item to add:");
//                 Console.WriteLine("1. Shirt - 0.5 lbs");
//                 Console.WriteLine("2. Jeans - 1.0 lbs");
//                 Console.WriteLine("3. Jacket - 1.5 lbs");
//                 break;
//             case "3":
//                 Console.WriteLine("Choose an item to add:");
//                 Console.WriteLine("1. Chair - 10 lbs");
//                 Console.WriteLine("2. Table - 20 lbs");
//                 Console.WriteLine("3. Sofa - 50 lbs");
//                 break;
//             default:
//                 Console.WriteLine("Invalid category choice.");
//                 return;
//         }

//         string itemChoice = Console.ReadLine();
//         Item item = null;

//         switch (categoryChoice)
//         {
//             case "1":
//                 switch (itemChoice)
//                 {
//                     case "1":
//                         item = new Item("Apple", 2);
//                         break;
//                     case "2":
//                         item = new Item("Banana", 1);
//                         break;
//                     case "3":
//                         item = new Item("Cheetos", 3);
//                         break;
//                     default:
//                         Console.WriteLine("Invalid choice.");
//                         return;
//                 }
//                 break;
//             case "2":
//                 switch (itemChoice)
//                 {
//                     case "1":
//                         item = new Item("Shirt", 0.5);
//                         break;
//                     case "2":
//                         item = new Item("Jeans", 1.0);
//                         break;
//                     case "3":
//                         item = new Item("Jacket", 1.5);
//                         break;
//                     default:
//                         Console.WriteLine("Invalid choice.");
//                         return;
//                 }
//                 break;
//             case "3":
//                 switch (itemChoice)
//                 {
//                     case "1":
//                         item = new Item("Chair", 10);
//                         break;
//                     case "2":
//                         item = new Item("Table", 20);
//                         break;
//                     case "3":
//                         item = new Item("Sofa", 50);
//                         break;
//                     default:
//                         Console.WriteLine("Invalid choice.");
//                         return;
//                 }
//                 break;
//         }

//         cart.AddItem(item);
//     }
// }
