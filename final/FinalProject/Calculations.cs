public static class Calculations
{
    public static double CalculateSpeed(double totalWeight)
    {
        if (totalWeight <= 5)
        {
            return 30; // mph
        }
        else if (totalWeight <= 10)
        {
            return 25;
        }
        else if (totalWeight <= 15)
        {
            return 20;
        }
        else
        {
            return 15;
        }
    }

    public static double CalculateDeliveryTime(double distance, double speed)
    {
        return distance / speed;
    }

    public static void BreathingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
