using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Device> devices = new List<Device>
        {
            new Laptop("Dell XPS 13", "Dell", "Intel i7"),
            new Smartphone("iPhone 13", "Apple", "iOS"),
            new Smartphone("iPhone 14 Pro Max", "Apple","iOS"),
            new Tablet("Galaxy Tab S7", "Samsung", 11)
        };

        foreach (var device in devices)
        {
            device.DisplayDetails();
        }
    }
}
