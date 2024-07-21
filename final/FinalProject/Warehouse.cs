// using System;
// using System.Collections.Generic;
// using System.IO;

// public class StreetDistanceLoader()
// {
//     string filePath = "streetDistances.txt";
    
//         // Read all lines from the text file
//         string[] lines = File.ReadAllLines(filePath);
//     // public Dictionary<string, double> StreetDistances { get; private set; }

//     // public StreetDistanceLoader()
//     {
//         StreetDistances = new Dictionary<string, double>();
//     }

//     public void LoadDistances (string (filePath))
//     {
//         if (!File.Exists("streetDistnaces.txt"))
//         {
//             throw new FileNotFoundException($"The file at {filePath} was not found.");
//         }

//         string[] lines = File.ReadAllLines("streetDistances.txt);

//         foreach (string line in lines)
//         {
//             string[] parts = line.Split(',');

//             if (parts.Length == 2)
//             {
//                 string streetName = parts[0].Trim();
//                 if (double.TryParse(parts[1].Trim(), out double distance))
//                 {
//                     StreetDistances[streetName] = distance;
//                 }
// public class Warehouse
// {
//     public string Address { get; set; }
//     public (double, double) Coordinates { get; set; }

//     public Warehouse(string address, (double, double) coordinates)
//     {
//         Address = address;
//         Coordinates = coordinates;
//     }
// }

// public class Order
// {
//     private Warehouse warehouse;
//     private Cart cart;
//     private string streetName;
//     // private (double, double) deliveryCoordinates;
//     private double speed;
//     private double distance;
//     private double deliveryTime;

//     public Order(Warehouse warehouse, Cart cart)
//     {
//         this.warehouse = warehouse;
//         this.cart = cart;
//     }

//     public void SetDeliveryAddress(string address)
//     {
//         deliveryAddress = address;
//         // Simulate address to coordinates conversion
//         deliveryCoordinates = AddressConverter.ConvertAddressToCoordinates(address);
//     }

//     public void CalculateDistance()
//     {
//         // Simplified distance calculation (Euclidean distance)
//         distance = Math.Sqrt(Math.Pow(warehouse.Coordinates.Item1 - deliveryCoordinates.Item1, 2) +
//                              Math.Pow(warehouse.Coordinates.Item2 - deliveryCoordinates.Item2, 2));
//     }

//     public void CalculateSpeedAndTime()
//     {
//         double totalWeight = cart.GetTotalWeight();
//         if (totalWeight <= 5)
//         {
//             speed = 30; // mph
//         }
//         else if (totalWeight <= 10)
//         {
//             speed = 25;
//         }
//         else if (totalWeight <= 15)
//         {
//             speed = 20;
//         }
//         else
//         {
//             speed = 15;
//         }
//         deliveryTime = distance / speed;
//     }

//     public void DisplayOrderSummary()
//     {
//         Console.WriteLine("Order Summary:");
//         cart.DisplayCart();
//         Console.WriteLine($"Delivery Address: {deliveryAddress}");
//         Console.WriteLine($"Distance: {distance:F2} miles");
//         Console.WriteLine($"Estimated Delivery Time: {deliveryTime:F2} hours");
//     }
// }

// public static class AddressConverter
// {
//     public static (double, double) ConvertAddressToCoordinates(string address)
//     {
//         // Simulated conversion
//         Random rand = new Random();
//         return (rand.NextDouble() * 100, rand.NextDouble() * 100);
//     }
// }



// using System;
// using System.Collections.Generic;
// using System.IO;

// public class StreetDistanceLoader
// {
//     public Dictionary<string, double> StreetDistances { get; private set; }

//     public StreetDistanceLoader()
//     {
//         StreetDistances = new Dictionary<string, double>();
//     }

//     public void LoadDistances(string "streetDistances.txt");
//     {
//         if (!File.Exists(filePath))
//         {
//             throw new FileNotFoundException($"The file at {filePath} was not found.");
//         }

//         string[] lines = File.ReadAllLines("streetDistances.txr);

//         foreach (string line in lines)
//         {
//             string[] parts = line.Split(',');

//             if (parts.Length == 2)
//             {
//                 string streetName = parts[0].Trim();
//                 if (double.TryParse(parts[1].Trim(), out double distance))
//                 {
//                     StreetDistances[streetName] = distance;
//                 }
//             }
//         }
//     }
// }
