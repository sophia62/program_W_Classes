public class Order
{
    private double distance;
    private Cart cart;
    private double deliveryTime;

    public Order(double distance, Cart cart)
    {
        this.distance = distance;
        this.cart = cart;
    }

    public void CalculateAndDisplaySummary()
    {
        double totalWeight = cart.GetTotalWeight();
        double speed = Calculations.CalculateSpeed(totalWeight);
        deliveryTime = Calculations.CalculateDeliveryTime(distance, speed);
        DisplayOrderSummary();
    }

    public static void Checkout(Cart cart, Dictionary<string, double> streetDistances)
    {
        Console.WriteLine("Enter your delivery address (street name):");
        string address = Console.ReadLine();

        if (streetDistances.TryGetValue(address, out double distance))
        {
            var order = new Order(distance, cart);
            order.CalculateAndDisplaySummary();

            Console.WriteLine("Confirm your order? (y/n)");
            string confirmation = Console.ReadLine();
            if (confirmation.ToLower() == "y")
            {
                Console.Write("Packing your order");
                Calculations.BreathingAnimation(3);
                Console.WriteLine("Order packed!");
                order.DisplayOrderSummary();
                Console.WriteLine("Thank you for shopping with us today!");
            }
            else
            {
                Console.WriteLine("Order cancelled.");
            }
        }
        else
        {
            Console.WriteLine("Invalid address.");
        }
    }

    public void DisplayOrderSummary()
    {
        Console.WriteLine("\n***** Order Summary *****");
        cart.DisplayCart();
        Console.WriteLine($"Distance: {distance:F2} miles");
        Console.WriteLine($"Estimated Delivery Time: {deliveryTime:F2} hours");
        Console.WriteLine("*************************");
    }
}




