// public abstract class Item
// {
//     public string Name { get; }
//     public double Weight { get; }

//     protected Item(string name, double weight)
//     {
//         Name = name;
//         Weight = weight;
//     }

//     public abstract void Display();
// }


// using System;
// using System.Collections.Generic;

// public class Cart
// {
//     private List<Item> _items = new List<Item>();

//     public void AddItem(Item item)
//     {
//         _items.Add(item);
//     }

//     public void RemoveItem(int index)
//     {
//         if (index >= 0 && index < _items.Count)
//         {
//             _items.RemoveAt(index);
//         }
//     }

//     public void DisplayCart()
//     {
//         Console.WriteLine("Items in cart:");
//         for (int i = 0; i < _items.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {_items[i].Name} - {_items[i].Weight} lbs");
//         }
//     }

//     public double TotalWeight()
//     {
//         double totalWeight = 0;
//         foreach (var item in _items)
//         {
//             totalWeight += item.Weight;
//         }
//         return totalWeight;
//     }
// }



// public class Item : BaseItem
// {
//     public Item(string name, double weight) : base(name, weight) { }
// }

// public class Cart
// {
//     private List<Item> items = new List<Item>();
//     private const double MaxWeight = 20.0;
//     private const int MaxItems = 3;

//     public void AddItem(Item item)
//     {
//         if (items.Count >= MaxItems || GetTotalWeight() + item.Weight > MaxWeight)
//         {
//             Console.WriteLine("Cart is full. You need to remove an item first. Max weight is 20 lbs. Max items is 3 items.");
//         }
//         else
//         {
//             items.Add(item);
//             Console.WriteLine($"{item.Name} added to cart.");
//         }
//     }

//     public void RemoveItem(int index)
//     {
//         if (index >= 0 && index < items.Count)
//         {
//             Console.WriteLine($"{items[index].Name} removed from cart.");
//             items.RemoveAt(index);
//         }
//         else
//         {
//             Console.WriteLine("Invalid item index.");
//         }
//     }

//     public void DisplayCart()
//     {
//         Console.WriteLine("Items in cart:");
//         for (int i = 0; i < items.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {items[i].Name} - {items[i].Weight} lbs");
//         }
//         Console.WriteLine($"Total weight: {GetTotalWeight()} lbs");
//     }

//     public double GetTotalWeight()
//     {
//         double totalWeight = 0;
//         foreach (var item in items)
//         {
//             totalWeight += item.Weight;
//         }
//         return totalWeight;
//     }

//     public List<Item> GetItems()
//     {
//         return items;
//     }
// }
