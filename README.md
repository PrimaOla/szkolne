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


## Dlaczego last merge nie był fast-forward?

Merge `feature-max` do `main` **nie był fast-forward** z następujących powodów:

1. **Dwie niezależne gałęzie** - Po utworzeniu `feature-max` dodaliśmy nowy commit bezpośrednio na `main` (README.md)
2. **Dywergencja historii** - Obie gałęzie miały swoje własne commity: 
   - `feature-max`: Add CalculateMax method
   - `main`: Add README with project documentation
3. **Brak liniowej historii** - Git nie mógł po prostu przesunąć wskaźnika, bo historia się rozeszła
4. **Konieczność merge commita** - Git stworzył **commit merge'a**, który łączy obie gałęzie

To jest **3-way merge** - Git musiał połączyć dwie diverging gałęzie.

## Autor

PrimaOla

## Licencja

PJATK

