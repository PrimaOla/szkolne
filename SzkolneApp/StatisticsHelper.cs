namespace SzkolneApp;

public class StatisticsHelper
{
    public static double CalculateAverage(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }
        
        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }
        
        return sum / numbers.Count;
    }
    
    public static double FindMaximum(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }
        
        return numbers.Max();
    }
    
    public static double FindMinimum(List<double> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0;
        }
        
        return numbers.Min();
    }

        
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }
        
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }
        
        return (double)sum / values.Length;
    }

        
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }
        
        int max = values[0];
        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }
        
        return max;
    }
}