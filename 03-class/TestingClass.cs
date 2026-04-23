
partial class Program
{
    static void TestingClass()
    {
        SeparatorTitle("Clases");
        Vehicle vehicle = new Vehicle();
        vehicle.modelVehicle = "Toyota";
        vehicle.nameVehicle = "Corola";
        vehicle.yearVehicle = 2025;
        vehicle.ShowInfoVehicle();

        Vehicle vehicle2 = new Vehicle("Supra","Toyota", 1995);
        vehicle2.ShowInfoVehicle();
    }
}


class Vehicle
{
    //Contenido de clase es: Propiedades y metodos

    public string? nameVehicle {get; set;}
    public string? modelVehicle {get; set;}
    public int yearVehicle {get; set;}

    //Metodo contructor
    public Vehicle(string name, string model, int year)
    {
        nameVehicle = name;
        modelVehicle = model;
        yearVehicle = year;
    }

    public Vehicle() {}


    public void ShowInfoVehicle()
    {
        WriteLine($"El vehiculo es {nameVehicle} su modelo es {modelVehicle} y su año es {yearVehicle}");
    }
}