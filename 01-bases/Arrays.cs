

partial class Program
{
    static void Arrays()
    {
        int[] number = new int[5];
        number[0] = 1;
        number[1] = 2;
        number[2] = 3;

        int[] numbers2 = { 10, 20, 30, 40, 50 };
        SeparatorTitle("Arrays");
        Print($"Primer elemento del array: {number[0]}");
        Print($"Segundo elemento del array: {number[1]}");

        Print($"Numero de elementos: {number.Length}");
        Print($"Ultimo elemento: {number[^1]}");

    }
}
