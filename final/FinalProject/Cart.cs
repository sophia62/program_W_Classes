using System;
using System.Collections.Generic;

public class Cart
{
    private List<BaseItem> items = new List<BaseItem>();
    private const double MaxWeight = 20.0;
    private const int MaxItems = 3;

    public void AddItem(BaseItem item)
    {
        if (items.Count >= MaxItems || GetTotalWeight() + item.Weight > MaxWeight)
        {
            Console.WriteLine("Cart is full. You need to remove an item first.");
        }
        else
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added to cart.");
        }
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            Console.WriteLine($"{items[index].Name} removed from cart.");
            items.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid item index.");
        }
    }

    public void DisplayCart()
    {
        Console.WriteLine("Items in cart:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i].Name} - {items[i].Weight} lbs");
        }
        Console.WriteLine($"Total weight: {GetTotalWeight()} lbs");
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (var item in items)
        {
            totalWeight += item.Weight;
        }
        return totalWeight;
    }

    public List<BaseItem> GetItems()
    {
        return items;
    }

    public void AddItemToCart()
    {
        Console.WriteLine("\nChoose a category:");
        Console.WriteLine("1. Food");
        Console.WriteLine("2. Clothing");
        Console.WriteLine("3. Furniture");

        string categoryChoice = Console.ReadLine();

        switch (categoryChoice)
        {
            case "1":
                FoodItem.DisplayItems(this);
                break;
            case "2":
                ClothingItem.DisplayItems(this);
                break;
            case "3":
                FurnatureItem.DisplayItems(this);
                break;
            default:
                Console.WriteLine("Invalid category choice.");
                return;
        }
    }
}


