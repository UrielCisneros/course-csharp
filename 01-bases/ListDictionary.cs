

partial class Program
{
    static void RunListDictionary()
    {
        SeparatorTitle("List and Dictionary");
        List<string> names = new List<string> { "Uriel", "Cisneros", "Gomez" };
        PrintLine("List of names:");
        foreach (string name in names)
        {
            PrintLine(name);    
        }

        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "amount", 30 },
            { "Cisneros", 25 },
            { "Gomez", 28 }
        };

    }

}
