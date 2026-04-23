

partial class Program
{
    static void Homework05()
    {
        SeparatorTitle("Homework 05 - Bus Class and Fleet Management");
        Bus bus1 = new Bus("Mercedes", "Sprinter", 2020, 50000, 100000);
        Bus bus2 = new Bus("Ford", "Transit", 2019, 45000, 120000);

        bus1.ShowInfo();
        bus1.Drive(500);
        bus1.ShowPrice();

        bus2.ShowInfo();
        bus2.Drive(300);
        bus2.ShowPrice();

        Fleet fleet = new Fleet();
        fleet.AddBus(bus1);
        fleet.AddBus(bus2);

        fleet.ShowFleetInfo();
    }
}


class Bus
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int? Year { get; set; }
    public int? Price { get; set; }
    public int? TotalKilometers { get; set; }

    public Bus(string? brand, string? model, int? year, int? price, int? totalKilometers)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        TotalKilometers = totalKilometers;
    }

    public void ShowInfo()
    {

        WriteLine($"Brand: {Brand}");

        WriteLine($"Model: {Model}");

        WriteLine($"Year: {Year}");

        WriteLine($"Price: {Price}");

        WriteLine($"Total Kilometers: {TotalKilometers}");
    }

    public void Drive(int kilometers)
    {
        if (TotalKilometers.HasValue)
        {
            TotalKilometers += kilometers;
        }
    }

    public void ShowPrice()
    {
        if (Price.HasValue)
        {

            WriteLine($"Price: {Price}");
        }
    }
}

class Fleet
{
    public List<Bus> Buses { get; set; }

    public Fleet()
    {
        Buses = new List<Bus>();
    }

    public void AddBus(Bus bus)
    {
        Buses.Add(bus);
    }

    public void ShowFleetInfo()
    {
        foreach (var bus in Buses)
        {
            bus.ShowInfo();
        }
    }
}