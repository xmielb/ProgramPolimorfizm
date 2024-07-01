public abstract class Device
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public Device(string name, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
    }
    public abstract void DisplayDetails();
}
