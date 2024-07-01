public class Laptop : Device
{
    public string Processor { get; set; }

    public Laptop(string name, string manufacturer, string processor)
        : base(name, manufacturer)
    {
        Processor = processor;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Laptop: {Name}, Producent: {Manufacturer}, Procesor: {Processor}");
    }
}
