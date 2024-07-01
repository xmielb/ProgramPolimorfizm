public class Tablet : Device
{
    public int ScreenSize { get; set; }

    public Tablet(string name, string manufacturer, int screenSize)
        : base(name, manufacturer)
    {
        ScreenSize = screenSize;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Tablet: {Name}, Producent: {Manufacturer}, Rozmiary ekranu: {ScreenSize} cali");
    }
}
