namespace TaskMaster
{
    public class Queries(List<Task> _tasks)
    {
        private List<Task> Tasks = _tasks;

        public void ListTasks()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n------Lista de tareas------");
            WriteLine("{0,-10} | {1,-30} | {2,-11} | {3,-10}", "ID", "Descripción", "Estado", "Eliminada");
            WriteLine(new string('-', 70));

            foreach (var task in Tasks)
            {
                WriteLine("{0,-10} | {1,-30} | {2,-11} | {3,-10}",
                    task.Id,
                    task.Description,
                    task.Completed ? "Completada" : "Pendiente",
                    task.Deleted ? "Sí" : "No");
            }

            WriteLine(new string('-', 70));
        }

    }
}