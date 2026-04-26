
partial class Program
{

    public static List<Empleado> empleados = [];

    static void Homework06()
    {
        bool continuar = true;
        
        while (continuar)
        {
            try
            {
                WriteLine("");
                int employe = RenderMenu();
                continuar = RegisterUser(employe);
            }
            catch
            {
                WriteLine("Por favor seleccione un numero válido");
            }
        }
        
        WriteLine("\n¡Hasta luego!");
    }

    public static bool RegisterUser(int user)
    {
        switch (user)
        {
            case 1:
                RegisterEmpleadoTiempoCompleto();
                return true;
            case 2:
                RegisterEmpleadoParcial();
                return true;
            case 3:
                ShowEmployes();
                return true;
            case 4:
                WriteLine("Saliendo del sistema...");
                return false; // Termina el ciclo
            default:
                WriteLine("Opción inválida, vuelva a seleccionar");
                return true;
        }
    }

    public static void RegisterEmpleadoTiempoCompleto()
    {
        WriteLine("id:");
        int id = int.Parse(ReadLine()!);
        WriteLine("Nombre:");
        string name = ReadLine()!;
        WriteLine("Salario:");
        double salario = double.Parse(ReadLine()!);
        Empleado empleadoTiempoCompleto = new EmpleadoTiempoCompleto(name, id, salario);
        empleados.Add(empleadoTiempoCompleto);
    }

    public static void RegisterEmpleadoParcial()
    {
        WriteLine("id:");
        int id = int.Parse(ReadLine()!);
        WriteLine("Nombre:");
        string name = ReadLine()!;
        WriteLine("Tarifa por hora:");
        double tarifa = double.Parse(ReadLine()!);
        WriteLine("Horas trabajadas:");
        double horasTrabajadas = double.Parse(ReadLine()!);
        Empleado empleadoPorHora = new EmpleadoPorHora(name, id, tarifa, horasTrabajadas);
        empleados.Add(empleadoPorHora);
    }


    public static int RenderMenu()
    {
        WriteLine("Seleccione el tipo de usuario a registrar: ");
        WriteLine("");
        WriteLine("1.- Empleado de planta");
        WriteLine("2.- Empleado por hora");
        WriteLine("3.- Listar empleados registrados");
        WriteLine("4.- Salir");

        return int.Parse(ReadLine()!);
    }

    public static void ShowEmployes()
    {
        if (empleados.Count == 0)
        {
            WriteLine("No hay empleados registrados");
            return;
        }

        WriteLine($"\nTotal de empleados registrados: {empleados.Count}\n");
        foreach (var empleado in empleados)
        {
            WriteLine($"Salario de {empleado.Name}: {empleado.CalcularSalario():C}");
        }
    }

}



abstract class Empleado
{
    public string? Name { get; set; }
    public int Id { get; set; }

    public Empleado(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public abstract double CalcularSalario();
}

class EmpleadoTiempoCompleto : Empleado
{
    public double SalarioMensual { get; set; }
    public EmpleadoTiempoCompleto(string name, int id, double salarioMensual) : base(name, id)
    {
        SalarioMensual = salarioMensual;
    }

    public override double CalcularSalario()
    {
        return SalarioMensual;
    }
}


class EmpleadoPorHora : Empleado
{

    public double TarifaPorHora { get; set; }
    public double HorasTrabajadas { get; set; }

    public EmpleadoPorHora(string name, int id, double tarifaPorHora, double horasTrabajadas) : base(name, id)
    {
        TarifaPorHora = tarifaPorHora;
        HorasTrabajadas = horasTrabajadas;
    }

    public override double CalcularSalario()
    {
        return TarifaPorHora * HorasTrabajadas;
    }
}





