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
- `CalculateMin(int[] values)` - znajduje minimum w tablicy int

## Jak uruchomić

```bash
cd SzkolneApp
dotnet run


### Dlaczego last merge nie był fast-forward?

Merge `feature-max` do `main` **nie był fast-forward** z następujących powodów:
1. **Dwie niezależne gałęzie** - Po utworzeniu `feature-max` dodaliśmy nowy commit bezpośrednio na `main` (README.md)
2. **Dywergencja historii** - Obie gałęzie miały swoje własne commity: 
   - `feature-max`: Add CalculateMax method
   - `main`: Add README with project documentation
3. **Brak liniowej historii** - Git nie mógł po prostu przesunąć wskaźnika, bo historia się rozeszła
4. **Konieczność merge commita** - Git stworzył **commit merge'a**, który łączy obie gałęzie

To jest **3-way merge** - Git musiał połączyć dwie diverging gałęzie.

## Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Fast-forward wykonuje się gdy historia jest liniowa - na głównej gałęzi nie ma nowych commitów od czasu utworzenia gałęzi feature, więc Git po prostu przesuwa wskaźnik. Merge commit powstaje gdy historia się rozeszła - obie gałęzie mają swoje nowe commity, więc Git musi stworzyć specjalny commit, który je łączy.

## Czym w praktyce różni się merge od rebase?

Merge zachowuje pełną historię i tworzy commit merge'a, widać gałęzie i kiedy zmiana została zintegrowana. Rebase przepisuje commity na nową podstawę tworząc liniową historię bez commita merge'a, ale jest bardziej niebezpieczny dla commitów już wypchnętych na GitHub.

## W jaki sposób został rozwiązany konflikt w Twoim repozytorium?

Konflikt w pliku Program.cs rozwiązałam świadomie - wybrałam najlepsze elementy z obu gałęzi: userInput zamiast input (bardziej czytelne), "koniec" zamiast "quit" (bardziej naturalne). Upewniłam się na koniec, że kod nadal działa. 

#### Autor

PrimaOla / Aleksandra Olszewska



