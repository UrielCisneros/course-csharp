

partial class Program
{
    static void Generict()
    {
        SeparatorTitle("Generic type");
        string[] names = new string[] { "Uriel", "Cisneros", "Gomez" };
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        PrintLine($"Length of names array: {GetArrayLength(names)}");
        PrintLine($"Length of numbers array: {GetArrayLength(numbers)}");
    }

    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

