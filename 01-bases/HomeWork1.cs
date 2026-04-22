

partial class Program
{
    static void HomeWork1()
    {
        string product = "Dell XPS 15";
        int quantity = 5;
        double price = 1500.00;
        double totalAmount = 0.0;

        PrintLine($"Product: {product}");
        PrintLine($"Quantity: {quantity}");
        PrintLine($"Price: {price:C}");
        totalAmount = quantity * price;
        PrintLine($"Total Amount: {totalAmount:C}");
        Separator();

    }
}

