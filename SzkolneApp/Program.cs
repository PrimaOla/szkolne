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
}

Console.WriteLine();