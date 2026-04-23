

partial class Program
{
    static void PolimorfismoExample()
    {
        SeparatorTitle("Polymorphism Example - Character and Role Classes");
        HomeAppliance microwave = new Microwave("Samsung");
        HomeAppliance refrigerator = new Refrigerator("LG");
        microwave.ShowInfo();
        microwave.TurnOn();
        microwave.TurnOff();
        refrigerator.ShowInfo();
        refrigerator.TurnOn();
        refrigerator.TurnOff();
    }
}


abstract class HomeAppliance
{
    public string? Brand { get; set; }

    public void ShowInfo()
    {
        WriteLine($"Brand: {Brand}");
    }
    public abstract void TurnOn();
    public abstract void TurnOff();
}


class Microwave : HomeAppliance
{
    public Microwave(string brand)
    {
        Brand = brand;
    }

    public override void TurnOn()
    {
        WriteLine("Microwave is now ON.");
    }

    public override void TurnOff()
    {
        WriteLine("Microwave is now OFF.");
    }

}

class Refrigerator : HomeAppliance
{
    public Refrigerator(string brand)
    {
        Brand = brand;
    }

    public override void TurnOn()
    {
        WriteLine("Refrigerator is now ON.");
    }

    public override void TurnOff()
    {
        WriteLine("Refrigerator is now OFF.");
    }
}

