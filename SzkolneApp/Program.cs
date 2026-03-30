using SzkolneApp;

Console.WriteLine("=== Aplikacja do obliczania statystyk ===\n");

List<double> numbers = new List<double>();

Console.WriteLine("Podaj liczby do analizy (wpisz 'koniec' aby skończyć):");

while (true)
{
    Console.Write("Podaj liczbę lub napisz 'koniec': ");
    string userInput = Console.ReadLine() ?? "";
    

    // walidacja - czy input nie jest pusty
    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("BŁĄD: Wprowadź coś. Pole nie może być puste.");
        Console.ResetColor();
        continue; 
    }

    if (userInput.ToLower() == "koniec")

    {
        break;
    }
    
    if (double.TryParse(userInput, out double number))
    {
        numbers.Add(number);
        Console.WriteLine($"Dodano: {number}");
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

Console.WriteLine("\n=== Test metody CalculateMin"); 
int[] testMinArray = {10, 5, 30, 2, 50};
int testMin = StatisticsHelper.CalculateMin(testMinArray);
Console.WriteLine($"Minimum z testowej tablicy to {testMin}");