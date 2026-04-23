
partial class Program
{
    static void ShowPirates()
    {
        SeparatorTitle("Pirates Example - Pirate, MuguiwarasPirate, and AkagamiPirate Classes");
        GetMuguiwarasPirateInfo();
        GetAkagamiPirateInfo();
    }

    static void GetMuguiwarasPirateInfo()
    {
        SeparatorTitle("Muguiwaras Pirates");
        List<Pirate> pirates = new List<Pirate>
        {
            new MuguiwarasPirate("Monkey D. Luffy", 19, "Captain", 150.0),
            new MuguiwarasPirate("Roronoa Zoro", 21, "Swordsman", 120.0),
            new MuguiwarasPirate("Nami", 20, "Navigator", 100.0),
            new MuguiwarasPirate("Usopp", 19, "Sniper", 90.0),
            new MuguiwarasPirate("Sanji", 21, "Cook", 110.0),
            new MuguiwarasPirate("Tony Tony Chopper", 17, "Doctor", 80.0),
            new MuguiwarasPirate("Nico Robin", 30, "Archaeologist", 95.0),
            new MuguiwarasPirate("Franky", 36, "Shipwright", 105.0),
            new MuguiwarasPirate("Brook", 90, "Musician", 85.0),
            new MuguiwarasPirate("Jinbe", 44, "Helmsman", 115.0)
        };

        foreach (var pirate in pirates)
        {
            pirate.ShowInfo();
        }
    }

    static void GetAkagamiPirateInfo()
    {
        SeparatorTitle("Akagami Pirates");
        List<Pirate> pirates = new List<Pirate>
        {
            new AkagamiPirate("Shanks", 39, "Captain", 400.0),
            new AkagamiPirate("Benn Beckman", 45, "First Mate", 180.0),
            new AkagamiPirate("Lucky Roo", 40, "Gunner", 170.0),
            new AkagamiPirate("Yasopp", 38, "Sniper", 160.0)
        };

        foreach (var pirate in pirates)
        {
            pirate.ShowInfo();
        }
    }
}

class Pirate
{
    public string? Name { get; set; }
    public string? Tripulation { get; set; }
    public int? Age { get; set; }
    public double? powerLevel = 100.0;

    public Pirate(string? name, string? tripulation, int? age, double? powerLevel = null)
    {
        Name = name;
        Tripulation = tripulation;
        Age = age;
        if (powerLevel.HasValue)
        {
            this.powerLevel = powerLevel;
        }
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
    public MuguiwarasPirate(string? name, int? age, string? role = null, double? powerLevel = null) : base(name, "Muguiwaras", age, powerLevel)
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
    public AkagamiPirate(string? name, int? age, string? role = null, double? powerLevel = null) : base(name, "Akagami", age, powerLevel)
    {
        Role = role;
    }

    override public void ShowPowerLevel()
    {
        WriteLine($"Power Level: {powerLevel * 8.5} (Akagami boost!)");
    }
}