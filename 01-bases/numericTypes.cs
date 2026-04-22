
partial class Program
{
    static void NumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.14;
        decimal decimalNumber = 19.99m;
        float floatNumber = 2.718f;

        Print([$"Integer: {integerNumber}",
               $"Double: {doubleNumber}",
               $"Decimal: {decimalNumber}",
               $"Float: {floatNumber}"]);
        Separator();
    }
}