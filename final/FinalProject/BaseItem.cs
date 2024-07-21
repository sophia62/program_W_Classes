public abstract class BaseItem
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public BaseItem(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
      public abstract void DisplayDetails();
}
