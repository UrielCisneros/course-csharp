
partial class Program
{
    static void ShowPirates()
    {
        SeparatorTitle("Pirates Example - Pirate, MuguiwarasPirate, and AkagamiPirate Classes");
        MuguiwarasPirate luffy = new MuguiwarasPirate("Monkey D. Luffy", 19, "Captain");
        AkagamiPirate shanks = new AkagamiPirate("Shanks", 39, "Captain");
        luffy.ShowInfo();
        shanks.ShowInfo();
    }
}

class Pirate
{
    public string? Name { get; set; }
    public string? Tripulation { get; set; }
    public int? Age { get; set; }
    public double? powerLevel = 100.0;

    public Pirate(string? name, string? tripulation, int? age)
    {
        Name = name;
        Tripulation = tripulation;
        Age = age;
    }

    public void ShowInfo()
    {
        WriteLine($"Name: {Name}");
        WriteLine($"Tripulation: {Tripulation}");
        WriteLine($"Age: {Age}");
        ShowPowerLevel();
    }

    public virtual void ShowPowerLevel()
    {
        if (powerLevel.HasValue)
        {
            WriteLine($"Power Level: {powerLevel}");
        }
        else
        {
            WriteLine("Power Level is unknown.");
        }
    }
}


class MuguiwarasPirate : Pirate
{
    public string? Role { get; set; }
    public MuguiwarasPirate(string? name, int? age, string? role = null) : base(name, "Muguiwaras", age)
    {
        Role = role;
    }

    override public void ShowPowerLevel()
    {
        WriteLine($"Power Level: {powerLevel * 1.5} (Muguiwaras boost!)");
    }
}

class AkagamiPirate : Pirate
{
    public string? Role { get; set; }
    public AkagamiPirate(string? name, int? age, string? role = null) : base(name, "Akagami", age)
    {
        Role = role;
    }

    override public void ShowPowerLevel()
    {
        WriteLine($"Power Level: {powerLevel * 8.5} (Akagami boost!)");
    }
}