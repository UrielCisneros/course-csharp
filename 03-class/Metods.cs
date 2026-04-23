

partial class Program
{
    static void RunMetods()
    {
        Car car = new Car();
        car.Model = "Toyota";
        car.Year = "2020";

        WriteLine($"El modelo del carro es {car.Model} y su año es {car.Year}");

        car.ChangeModel("Honda");
        WriteLine($"El modelo del carro es {car.Model} y su año es {car.Year}");

        string info = car.ShowInfo();
        WriteLine(info);

        car.ShowMessage();
        car.ShowMessage("Este es un mensaje personalizado");
    }
}


class Car
{
    public string? Model { get; set; }
    public string? Year { get; set; }

    //Contructores
    public Car(string model, string year)
    {
        Model = model;
        Year = year;
    }

    public Car() { }

    //Destructor
    ~Car()
    {
        WriteLine("El objeto Car ha sido destruido");
    }


    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Model: {Model}, Year: {Year}";
    }
    public void ShowMessage() => WriteLine("Este es un automovil");
    public void ShowMessage(string message) => WriteLine(message);


}