

partial class Program
{
    static void Variables()
    {
        RunCode();

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void RunCode()
        {
            int number = 10;
            string text = "Uriel Cisneros";
            double pi = 3.1416;
            bool isActive = true;

            DisplayMessage($"Number: {number}");
            DisplayMessage($"Text: {text}");
            DisplayMessage($"Pi: {pi}");
            DisplayMessage($"Is Active: {isActive}");
            Separator();
        }
    }
}

