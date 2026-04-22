

partial class Program
{
    static void Generict()
    {
        SeparatorTitle("Generic type");
        string[] names = new string[] { "Uriel", "Cisneros", "Gomez" };
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        PrintLine($"Length of names array: {GetArrayLength(names)}");
        PrintLine($"Length of numbers array: {GetArrayLength(numbers)}");

        Box<int> boxInt = new Box<int> {Content = 10};
        Box<string> boxString = new Box<string> {Content = "Hello, Generics!"};

        boxInt.Show();
        boxString.Show();

    }

    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}


class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Contenido: {Content}");
    }
}