

partial class Program
{
    static void AnimasClass()
    {
        Animals animal = new Animals("Ocean");
        animal.Age = -1;
        animal.Category = "Mamifero";
        animal.Species = "Tortuga";
        WriteLine($"el animal vive en {animal.Habitat}, su edad es {animal.Age}, y su especie es {animal.Species}");
    }
}


class Animals
{

    public string Species { get; set; } = "Desconocida";
    public string Category { get; set; } = "Desconocida";
    public string Habitat { get; }

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa");
            }
            age = value;
        }
    }


    public Animals(string habitat)
    {
        Habitat = habitat;
    }


}

