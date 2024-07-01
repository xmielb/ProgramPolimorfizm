public class Smartphone : Device
{
    public string OperatingSystem { get; set; }

    public Smartphone(string name, string manufacturer, string operatingSystem)
        : base(name, manufacturer)
    {
        OperatingSystem = operatingSystem;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Smartfon: {Name}, Producent: {Manufacturer}, OS: {OperatingSystem}");
    }
}
