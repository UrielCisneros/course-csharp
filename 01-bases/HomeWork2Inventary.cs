

partial class Program
{
    static void RunInventary()
    {
        SeparatorTitle("Inventario de productos");
        ActionSelectes();
    }


    static void BuyProduct()
    {
        string[] products = { "Laptop", "Mause", "Teclado", "Monitor", "Impresora" };
        int[] stock = { 10, 25, 15, 8, 5 };
        double[] prices = { 750.50, 20.50, 45.00, 200.99, 150.00 };

        SeparatorTitle("Productos disponibles:");
        for (int i = 0; i < products.Length; i++)
        {
            PrintLine($"{i + 1}. {products[i]} - Stock: {stock[i]} - Precio: {prices[i]:C}");
        }
        PrintLine("");
        PrintLine("Ingrese el producto a comprar (nombre del producto):");
        PrintLine("");
        string? productSelected = Console.ReadLine();
        PrintLine("Ingrese la cantidad a comprar:");
        int quantity = int.Parse(Console.ReadLine()!);
        PrintLine("");

        for (int y = 0; y < products.Length; y++)
        {
            if (products[y].Equals(productSelected, StringComparison.OrdinalIgnoreCase))
            {
                if (stock[y] >= quantity)
                {
                    PrintLine($"Compra exitosa: {quantity} {products[y]} por un total de {(prices[y] * quantity):C}");
                }
                else
                {
                    PrintLine($"No hay suficiente stock de {products[y]}. Stock disponible: {stock[y]}");
                }
            }
        }


    }
    static void ActionSelectes()
    {
        PrintLine("Seleccione una accion:");
        PrintLine("");
        PrintLine("1. Comprar producto");
        PrintLine("2. Salir");
        PrintLine("");

        int action = int.Parse(Console.ReadLine()!);

        switch (action)
        {
            case 1:
                BuyProduct();
                break;
            case 2:
                PrintLine("Gracias por usar el inventario");
                break;
            default:
                PrintLine("Opcion no valida");
                break;
        }

    }

}


