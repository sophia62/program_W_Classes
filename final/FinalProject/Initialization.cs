public class Initialization
{
    public Dictionary<string, double> LoadStreetDistances(string filePath)
    {
        return FileOperations.LoadStreetDistances(filePath);
    }

    public Cart InitializeCart()
    {
        return new Cart();
    }
}
