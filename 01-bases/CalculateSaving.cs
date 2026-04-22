


partial class Program
{
    decimal saving_years = 0;
    decimal savings_now = 0;
    int years_of_saving = 0;
    double anual_interest = 0;

    Program(decimal Saving_Year, decimal Savings_Now, int Years_of_Saving, double Anual_Interest)
    {
        this.saving_years = Saving_Year;
        this.savings_now = Savings_Now;
        this.years_of_saving = Years_of_Saving;
        this.anual_interest = Anual_Interest;
    }

    static void RunCalculate()
    {
        CaptureData();
    }

    decimal CalculateTotalSavings()
    {
        decimal total_savings = savings_now;
        decimal temp_gain_year = 0.0m;
        for (int i = 0; i < years_of_saving; i++)
        {
            // Primero aplicar el interés, luego añadir el ahorro anual (como en JavaScript)
            total_savings += total_savings * (decimal)(anual_interest / 100);
            total_savings += saving_years;
            
            // Calcular ganancia del año actual (restando la ganancia acumulada anterior)
            decimal ganancia_total = CalculateGain(total_savings, i + 1);
            decimal ganancia_año_actual = ganancia_total - temp_gain_year;
            temp_gain_year = ganancia_total;
            
            SeparatorTrim();
            Print($"Año: {i + 1}");
            Print($"Ahorro total: {total_savings:C}");
            Print($"Ganancia total: {ganancia_total:C}");
            Print($"Ganancia del año actual: {ganancia_año_actual:C}");
            Print($"Ganancia por mes: {(ganancia_año_actual / 12):C}");
        }
        return total_savings;
    }

    static void CaptureData()
    {
        PrintLine("Ingrese el dinero que puede ahorrar por año:");
        decimal saving_years = Convert.ToDecimal(ReadLine());

        PrintLine("Ingrese la cantidad de dinero que ha ahorrado hasta ahora:");
        decimal savings_now = Convert.ToDecimal(ReadLine());

        PrintLine("Ingrese el número de años que planea ahorrar:");
        int years_of_saving = Convert.ToInt32(ReadLine());

        PrintLine("Ingrese la tasa de interés anual (en porcentaje):");
        double porsentaje = Convert.ToDouble(ReadLine());
        double anual_interest = porsentaje < 100 ? porsentaje / 100 : porsentaje;

        Program program = new Program(saving_years, savings_now, years_of_saving, anual_interest);
        decimal total_savings = program.CalculateTotalSavings();
        SeparatorMain();
        PrintLine($"Ganancia total: {years_of_saving} años: {total_savings:C}");
        SeparatorMain();
    }

    decimal CalculateGain(decimal total_savings, int year)
    {
        return total_savings - savings_now - (saving_years * year);
    }
}


