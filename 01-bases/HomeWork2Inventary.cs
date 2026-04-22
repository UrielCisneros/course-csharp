

partial class Program
{
    private string productBuy;
    private int stockBuy;
    private string[] products = { "Laptop", "Mause", "Teclado", "Monitor", "Impresora" };
    private int[] stock = { 10, 25, 15, 8, 5 };
    private double[] prices = { 750.50, 20.50, 45.00, 200.99, 150.00 };

    Program(string product, int stock)
    {
        this.productBuy = product;
        this.stockBuy = stock;
    }
    static void RunInventary()
    {
        SeparatorTitle("Inventario de productos");
        ActionSelectes();
    }

    static void ActionSelectes()
    {
        PrintLine("Seleccione una accion:");
        PrintLine("");
        PrintLine("1. Comprar producto");
        PrintLine("2. Salir");
        PrintLine("");

        int action = int.Parse(ReadLine()!);

        switch (action)
        {
            case 1:
                Program program = new Program("", 0);
                program.BuyProduct();
                break;
            case 2:
                PrintLine("Gracias por usar el inventario");
                break;
            default:
                PrintLine("Opcion no valida");
                break;
        }

    }



    void BuyProduct()
    {
        SeparatorTitle("Productos disponibles:");
        for (int i = 0; i < products.Length; i++)
        {
            PrintLine($"{i + 1}. {products[i]} - Stock: {stock[i]} - Precio: {prices[i]:C}");
        }
        PrintLine("");
        PrintLine("Ingrese el producto a comprar (nombre del producto):");
        PrintLine("");
        string? productSelected = ReadLine();
        PrintLine("Ingrese la cantidad a comprar:");
        int quantity = int.Parse(ReadLine()!);
        PrintLine("");

        Program program = new Program(productSelected!, quantity);
        program.ValidateStockProduct();

    }

    void ValidateStockProduct()
    {
        for (int y = 0; y < products.Length; y++)
        {
            if (products[y].Equals(productBuy, StringComparison.OrdinalIgnoreCase))
            {
                if (stock[y] >= stockBuy)
                {
                    PrintLine($"Compra exitosa: {stockBuy} {products[y]} por un total de {(prices[y] * stockBuy):C}");
                }
                else
                {
                    PrintLine($"No hay suficiente stock de {products[y]}. Stock disponible: {stock[y]}");
                }
            }
        }
    }
}


