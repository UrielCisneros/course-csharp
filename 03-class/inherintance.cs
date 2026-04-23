
partial class Program
{
    static void Inheritance()
    {
        SeparatorTitle("Inheritance Example - Character and Role Classes");
        Muguiwaras luffy = new Muguiwaras("Monkey D. Luffy", 19, "Captain");
        Muguiwaras zoro = new Muguiwaras("Roronoa Zoro", 21, "Swordsman");
        Akagami shanks = new Akagami("Shanks", 39, "Captain");
        luffy.ShowInfo();
        luffy.Greet();
        zoro.ShowInfo();
        zoro.Greet();
        shanks.ShowInfo();
        shanks.Greet();
    }
}

class Character
{
    public string? Name { get; set; }
    public int? Age { get; set; }

    public Character(string? name, int? age)
    {
        Name = name;
        Age = age;
    }

    public void ShowInfo()
    {
        WriteLine($"Name: {Name}");
        WriteLine($"Age: {Age}");
    }

    public virtual void Greet()
    {
        WriteLine($"Hello, I am {Name}.");
    }
}

class Muguiwaras : Character
{
    public string? Role { get; set; }

    public Muguiwaras(string? name, int? age, string? role) : base(name, age)
    {
        Role = role;
    }

    public override void Greet()
    {
        WriteLine($"Hello, I am {Name}, the {Role} of the Muguiwaras.");
    }
}


class Akagami : Character
{
    public string? Role { get; set; }

    public Akagami(string? name, int? age, string? role) : base(name, age)
    {
        Role = role;
    }

    public override void Greet()
    {
        WriteLine($"Hello, I am {Name}, the {Role} of the Akagami.");
    }
}