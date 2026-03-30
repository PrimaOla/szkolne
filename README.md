# Szkolne - Aplikacja do obliczania statystyk

## Opis projektu

To jest prosta aplikacja konsolowa napisana w C# (.NET), która pozwala na:
- Wprowadzanie liczb
- Obliczanie średniej
- Znajdowanie maksimum i minimum
- Obsługę błędów dla niepoprawnych danych wejściowych

## Funkcjonalności

### StatisticsHelper - Klasy pomocnicze

- `CalculateAverage(List<double> numbers)` - oblicza średnią arytmetyczną
- `CalculateAverage(int[] values)` - przeciążona wersja dla tablicy int
- `FindMaximum(List<double> numbers)` - znajduje wartość maksymalną
- `FindMinimum(List<double> numbers)` - znajduje wartość minimalną
- `CalculateMax(int[] values)` - znajduje maksimum w tablicy int

## Jak uruchomić

```bash
cd SzkolneApp
dotnet run