using System;
using System.Collections.Generic;

internal class Program
{
    private static bool isFirstRun = true;

    static void Main(string[] args)
    {
        if (isFirstRun)
        {
            DisplayWelcomeMessage();
            isFirstRun = false;
        }

        var initialization = new Initialization();
        var streetDistances = initialization.LoadStreetDistances("streetDistances.txt");
        var cart = initialization.InitializeCart();

        while (true)
        {
            Console.WriteLine("1. Add item to cart");
            Console.WriteLine("2. Remove item from cart");
            Console.WriteLine("3. View cart");
            Console.WriteLine("4. Checkout");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    cart.AddItemToCart();
                    break;
                case "2":
                    cart.DisplayCart();
                    Console.WriteLine("Enter the number of the item to remove:");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        cart.RemoveItem(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "3":
                    cart.DisplayCart();
                    break;
                case "4":
                    Order.Checkout(cart, streetDistances);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Hello! Welcome to BYU packing drone facility.");
        Console.WriteLine("Please choose up to three items and/or 20 pounds so the drones can deliver your packages safely.");
        Console.WriteLine("When you are finished, check out and put your street name.");
        Console.WriteLine("We will calculate your estimated wait time based on the weight of your package. Enjoy!");
        Console.WriteLine();
    }
}









