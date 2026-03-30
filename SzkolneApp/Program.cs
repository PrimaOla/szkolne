using SzkolneApp;

Console.WriteLine("=== Aplikacja do obliczania statystyk ===\n");

List<double> numbers = new List<double>();

Console.WriteLine("Podaj liczby do analizy (wpisz 'koniec' aby skończyć):");

while (true)
{
    Console.Write("Liczba: ");
    string input = Console.ReadLine() ?? "";
    
    if (input.ToLower() == "koniec")
    {
        break;
    }
    
    if (double.TryParse(input, out double number))
    {
        numbers.Add(number);
        Console.WriteLine($"✓ Dodano: {number}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("BŁĄD: To nie jest prawidłowa liczba. Spróbuj ponownie.");
        Console.ResetColor();
    }
}



Console.WriteLine();


if (numbers.Count > 0)
{
    double average = StatisticsHelper.CalculateAverage(numbers);
    double maximum = StatisticsHelper.FindMaximum(numbers);
    double minimum = StatisticsHelper.FindMinimum(numbers);
    
    Console.WriteLine("=== Statystyki ===");
    Console.WriteLine($"Średnia: {average:F2}");
    Console.WriteLine($"Maksimum: {maximum}");
    Console.WriteLine($"Minimum: {minimum}");
}
else if (numbers.Count == 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("BŁĄD: Nie podano żadnych liczb. Nie można obliczyć statystyk.");
    Console.ResetColor();
}