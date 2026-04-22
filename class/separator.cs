

partial class Program
{
    static void Separator()
    {
        Print("");
        Print("------------------------------");
        Print("");
    }

    static void SeparatorTrim()
    {
        Print("------------------------------");
    }

    static void SeparatorMain()
    {
        Print("===============================");
    }


    static void SeparatorTitle(string title)
    {
        Print("");
        Print($"-----------{title}-----------");
        Print("");
    }
}