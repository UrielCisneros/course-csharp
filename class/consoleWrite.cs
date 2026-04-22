


partial class Program
{
    static void Print(params object[] args)
    {
        foreach (var message in args)
        {
            Console.WriteLine(message);
        }
    }

    static void PrintLine(string message)
    {
        Console.WriteLine(message);
    }
}
