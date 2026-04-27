using BetterConsoleTables;
namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n------Lista de tareas------");
            Table table = new Table("ID", "Descripción", "Estado", "Eliminada");
            foreach (var task in Tasks)
            {
                table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "Pendiente", task.Deleted ? "Sí" : "No");
            }
            table.Config = TableConfiguration.Unicode();
            WriteLine(table.ToString());
        }

        public List<Task> AddTasck()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("------Añadir nueva tarea------");
                Write("Ingrese la descripción de la tarea: ");
                string description = ReadLine()!;
                string id = Utils.GenerateId();
                Task newTask = new Task(id, description);
                Tasks.Add(newTask);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea añadida exitosamente.");
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al añadir la tarea: {ex.Message}");
                return Tasks;
            }
        }
    }
}