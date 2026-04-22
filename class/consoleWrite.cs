


partial class Program
{
    static void Print(params object[] args)
    {
        foreach (var message in args)
        {
            WriteLine(message);
        }
    }

    static void PrintLine(string message)
    {
        WriteLine(message);
    }
}
